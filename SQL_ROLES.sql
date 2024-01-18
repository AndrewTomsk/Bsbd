Use Склад 
Create role Администратор
Go
Grant SELECT on Накладная to Бухгалтер
Grant SELECT on Персонал to Бухгалтер
Grant SELECT on Приемка_Товара to Бухгалтер
GO
Create LOGIN Бухгалтер with password = '12345',
Check_Expiration = off
create user user_Buh for login Бухгалтер
alter role Бухгалтер add member user_Buh
Go
Create role Кладовщик
Go
Grant SELECT,UPDATE,INSERT on Накладная to Кладовщик
Grant SELECT on Персонал to Кладовщик
Grant SELECT on Поставщик to Кладовщик
Grant SELECT,UPDATE,INSERT on Товары_Склада to Кладовщик
Grant SELECT,UPDATE,INSERT on Приемка_Товара to Кладовщик
GO
Create LOGIN Кладовщик with password = '12345',
Check_Expiration = off
create user user_Whs for login Кладовщик
alter role Кладовщик add member user_Whs