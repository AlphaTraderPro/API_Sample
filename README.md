## How to use:
1. Working with API is possible via any Web-browser using just its address line.
2. Use code examples to implement custom scripts. Examples provided in Python and C# but any language with native HTTP client library is supported. 

## API Connection state:
### /connection

Output sample (as JSON dict):

{"connected":"1"}

## Submitting orders:
### /sendOrder?%variables%

Valid sendOrder examples:

http://localhost:5005/sendOrder?symbol=SPY&qty=100&exchange=bats&type=limit&side=buy&price=100.0

http://localhost:5005/sendOrder?symbol=SPY&qty=100&exchange=bats&type=market&side=buy&price=0

http://localhost:5005/sendOrder?symbol=SPY&qty=100&exchange=bats&type=stop&side=sell&price=99

Supported variables:

symbol:    any supported symbol

qty:       order quantity >=0

exchange:  any supported ECN

type:      limit, market, stop (note: only stop-market orders supported, stop-limit orders not supported yet)

side:      buy, sell

price:     buy/sell limit or stop trigger price, should set 0 for market orders


## Canceling orders:
### /cancelOrder?%variables%

Valid cancelOrder example:

http://localhost:5005/cancelOrder?id=TEST123+2271911253168446?

Supported variables:

id:    active order id from /orders table 

## Listing orders:
### /orders

Output sample (as JSON dict):

"{TEST123+229139323021770?:[OrderID=TEST123+229139323021770?, Symbol=BAC, Side=BUY, Qty=10, Price=492.51, OrderType=Limit, StopPrice=0, Status=Filled],

TEST123+229139333951586?:[OrderID=TEST123+229139333951586?, Symbol=BAC, Side=SELL, Qty=10, Price=34.56, OrderType=Limit, StopPrice=0, Status=Filled],

TEST123+22913622582203?:[OrderID=TEST123+22913622582203?, Symbol=SPY, Side=SELL, Qty=1, Price=200, OrderType=Limit, StopPrice=0, Status=Filled]}"

## Listing positions:
### /positions

Output sample (as JSON list):

["[TraderID=TEST123, Symbol=BAC, Qty=-10, PosAvgPrice=34.56, Side=Short, LastPrice = 34.375, Unrealized = 1.8, NetPnl = 0.39, GrossPnl = 0.6, TotalQty = 30]",

"[TraderID=TEST123, Symbol=SPY, Qty=12, PosAvgPrice=402.6833, Side=Long, LastPrice = 400.87, Unrealized = -22, NetPnl = -12.11, GrossPnl = -12.01, TotalQty = 14]"]

