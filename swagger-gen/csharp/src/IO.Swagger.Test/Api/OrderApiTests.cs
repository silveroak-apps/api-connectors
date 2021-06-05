/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api.bybit.com]  
 *
 * OpenAPI spec version: 0.2.10
 * Contact: support@bybit.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;
using System.Threading.Tasks;

using IO.Swagger.Client;
using IO.Swagger.Api;

using BybitOrderResponse = IO.Swagger.Model.OrderResBase;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing OrderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrderApiTests
    {
        private OrderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OrderApi
            //Assert.IsInstanceOfType(typeof(OrderApi), instance, "instance is a OrderApi");
        }

        
        /// <summary>
        /// Test OrderCancel
        /// </summary>
        [Test]
        public void OrderCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string orderId = null;
            //string orderLinkId = null;
            //var response = instance.OrderCancel(symbol, orderId, orderLinkId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OrderCancelAll
        /// </summary>
        [Test]
        public void OrderCancelAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.OrderCancelAll(symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OrderGetOrders
        /// </summary>
        [Test]
        public void OrderGetOrdersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //decimal? limit = null;
            //string orderStatus = null;
            //string direction = null;
            //string cursor = null;
            //var response = instance.OrderGetOrders(symbol, limit, orderStatus, direction, cursor);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OrderNew
        /// </summary>
        [Test]
        public async Task OrderNewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            // let o =
            
            string side = "Buy";
            string symbol = "BTCUSD";
            string orderType = "Limit";
            decimal? qty = 1;
            string timeInForce = "GoodTillCancel";
            double? price = 20;
            double? takeProfit = null;
            double? stopLoss = null;
            bool? reduceOnly = null;
            bool? closeOnTrigger = null;
            string orderLinkId = "abcd";
            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            
            Console.Out.WriteLine("Timestamp --> "+timestamp);
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            parameters.Add("side", side);
            parameters.Add("symbol", symbol);
            parameters.Add("orderType", orderType);
            parameters.Add("qty",qty.ToString());
            parameters.Add("timeInForce", timeInForce);
            parameters.Add("price", price.ToString());
            parameters.Add("orderLinkId", orderLinkId);
            parameters.Add("timestamp", timestamp); 
            parameters.Add("api_key", "w0ddzkzS3kMExz4Xpc");
            instance.Configuration.AddApiKeyPrefix("api_key", "w0ddzkzS3kMExz4Xpc");
            instance.Configuration.AddApiKeyPrefix("sign", Common.getSignature("ppsAOlX859PcREd3nOjJ5LAJwg39UGB1S2t2", parameters));
            instance.Configuration.AddApiKeyPrefix("timestamp",timestamp);
            var response = await instance.OrderNewAsync(side, 
                symbol, orderType, qty, 
                timeInForce, price, takeProfit, 
                stopLoss, reduceOnly, closeOnTrigger, 
                orderLinkId);

            var jobj = (Newtonsoft.Json.Linq.JObject) response;

            var orderResponse = jobj.ToObject<BybitOrderResponse>(); // TODO do both COINM/USDT return the same type?
            Console.Out.WriteLine("Log statement to debug"+orderResponse);
            Assert.IsInstanceOf<Object> (orderResponse, "response is Object");
        }
        
        /// <summary>
        /// Test OrderQuery
        /// </summary>
        [Test]
        public void OrderQueryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string orderId = null;
            //string symbol = null;
            //var response = instance.OrderQuery(orderId, symbol);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test OrderReplace
        /// </summary>
        [Test]
        public void OrderReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //string orderId = null;
            //string orderLinkId = null;
            //string pRQty = null;
            //string pRPrice = null;
            //var response = instance.OrderReplace(symbol, orderId, orderLinkId, pRQty, pRPrice);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
