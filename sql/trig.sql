delimiter #
create trigger totalP
After insert on orders
for each row
begin
    if new.orderNo is not null
    insert into orderpayment
    values(new.orderNo,(select sum(price) from productoders join products on productSrNo=SrNo where productSrNo=SrNo))
    end
    
delimiter #    


 delimiter @
create trigger BuyerU
After update on orders
for each row
begin
    if new.orderNo is not null
    update orders
    set new.orderNo=old.orderNo
    where old.oType=new.oType and old.orderDate=new.orderDate
    end
    
delimiter @   




    