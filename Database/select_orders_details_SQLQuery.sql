select d.product_id,p.name,p.price,
d.Quantite,(p.price*d.Quantite) as total
from the_order o inner join Ordre_details d
on o.id = d.order_id inner join products p
on  p.id=d.product_id