#!/usr/bin/python
import urllib.request

#send order

symbol = "tsla"
qty=100
exchange="bats"
type = "limit"
side="buy"
price=300.99

result = urllib.request.urlopen("http://localhost:5005/sendOrder?symbol="+symbol+"&qty="+str(qty)+"&exchange="+exchange+"&type="+type+"&side="+side+"&price="+str(price)).read()
print(result)

#view all orders
orders_table = urllib.request.urlopen("http://localhost:5005/orders").read()
print(orders_table)

#cancel order by ID

id = "TEST123+22721104994672?"
result = urllib.request.urlopen("http://localhost:5005/cancelOrder?id="+id).read()
print(result)

#view all positions
positions_table = urllib.request.urlopen("http://localhost:5005/positions").read()
print(positions_table)