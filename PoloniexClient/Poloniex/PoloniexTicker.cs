﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using WampSharp.V2;

namespace CryptoMarketClient {
    public class PoloniexTicker : ITicker {
        public PoloniexTicker() {
            History = new List<TickerHistoryItem>();
        }

        public int Id { get; set; }

        string currensyPair;
        public string CurrencyPair {
            get { return currensyPair; }
            set {
                currensyPair = value;
                OnCurrencyPairChanged();
            }
        }
        void OnCurrencyPairChanged() {
            string[] curr = CurrencyPair.Split('_');
            FirstCurrency = curr[0];
            SecondCurrency = curr[1];
        }
        public string FirstCurrency {
            get; private set;
        }
        public string SecondCurrency {
            get; private set;
        }
        public double Last { get; set; }

        double lowestAsk;
        public double LowestAsk {
            get { return lowestAsk; }
            set {
                if(value != LowestAsk)
                    DeltaAsk = value - LowestAsk;
                lowestAsk = value;
            }
        }
        double highestBid;
        public double HighestBid {
            get { return highestBid; }
            set {
                if(value != HighestBid)
                    DeltaBid = value - HighestBid;
                highestBid = value;
            }
        }

        public double PercentChange { get; set; }
        public double BaseVolume { get; set; }
        public double QuoteVolume { get; set; }
        public bool IsFrozen { get; set; }
        public double Hr24High { get; set; }
        public double Hr24Low { get; set; }
        public DateTime Time { get; set; }

        public double DeltaAsk { get; set; }
        public double DeltaBid { get; set; }
        public List<TickerHistoryItem> History { get; } = new List<TickerHistoryItem>();
        public List<TradeHistoryItem> TradeHistory { get; } = new List<TradeHistoryItem>();

        public void Assign(PoloniexTicker ticker) {
            CurrencyPair = ticker.CurrencyPair;
            Last = ticker.Last;
            LowestAsk = ticker.LowestAsk;
            HighestBid = ticker.HighestBid;
            PercentChange = ticker.PercentChange;
            BaseVolume = ticker.BaseVolume;
            QuoteVolume = ticker.QuoteVolume;
            IsFrozen = ticker.IsFrozen;
            Hr24High = ticker.Hr24High;
            Hr24Low = ticker.Hr24Low;
            Time = ticker.Time;
        }

        public void UpdateHistoryItem() {
            if(History.Count > 36000)
                History.RemoveAt(0);
            History.Add(new TickerHistoryItem() { Time = Time, Ask = LowestAsk, Bid = HighestBid, Current = Last });
            RaiseHistoryItemAdded();
        }
        public event EventHandler HistoryItemAdd;
        void RaiseHistoryItemAdded() {
            if(HistoryItemAdd != null)
                HistoryItemAdd(this, EventArgs.Empty);
        }

        OrderBook orderBook;
        public OrderBook OrderBook {
            get {
                if(orderBook == null)
                    orderBook = new OrderBook(this);
                return orderBook;
            }
        }
        public bool IsActualState { get { return OrderBook.IsActualState; } }
        public void OnChanged() {
            RaiseChanged();   
        }
        void ITicker.OnChanged(OrderBookUpdateInfo info) {
            RaiseChanged();
        }
        protected internal void RaiseChanged() {
            if(Changed != null)
                Changed(this, EventArgs.Empty);
        }
        public void ConnectOrderBook(OrderBook orderBook) {
            throw new NotImplementedException();
        }

        public event EventHandler Changed;
        public event EventHandler TradeHistoryAdd;
        string ITicker.Name { get { return CurrencyPair; } }
        
        public void GetOrderBookSnapshot() {
            PoloniexModel.Default.GetOrderBook(this, 50);
        }
        TickerUpdateHelper updateHelper;
        protected TickerUpdateHelper UpdateHelper {
            get {
                if(updateHelper == null)
                    updateHelper = new TickerUpdateHelper(this);
                return updateHelper;
            }
        }
        void ITicker.SubscribeOrderBookUpdates() {
            UpdateHelper.SubscribeOrderBookUpdates();
        }
        void ITicker.UnsubscribeOrderBookUpdates() {
            UpdateHelper.UnsubscribeOrderBookUpdates();
        }
        void ITicker.SubscribeTickerUpdates() {
            UpdateHelper.SubscribeTickerUpdates();
        }
        void ITicker.UnsubscribeTickerUpdates() {
            UpdateHelper.UnsubscribeTickerUpdates();
        }
        void ITicker.SubscribeTradeUpdates() {
            UpdateHelper.SubscribeTradeUpdates();
        }
        void ITicker.UnsubscribeTradeUpdates() {
            UpdateHelper.UnsubscribeTradeUpdates();
        }
        void ITicker.UpdateOrderBook() {
            PoloniexModel.Default.GetOrderBook(this, 50);
        }
        void ITicker.UpdateTicker() {
            PoloniexModel.Default.GetTicker(this);
        }
        void ITicker.UpdateTrades() {
            PoloniexModel.Default.UpdateTrades(this);
        }
        public string DownloadString(string address) {
            throw new NotImplementedException();
        }
    }
}
