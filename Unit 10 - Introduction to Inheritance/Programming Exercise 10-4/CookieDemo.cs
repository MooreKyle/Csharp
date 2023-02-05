Instructions

Write an application for Nina’s Cookie Emporium named CookieDemo that declares and demonstrates objects of the CookieOrder class and its descendants. The CookieOrder class includes the following auto-implemented properties:

OrderNum - The order number
Name - The recipient’s name
CookieType - The cookie type (for example, chocolate chip)
The class should also include fields for number of dozens ordered and price (named Dozens and Price). When the field value for number of dozens ordered is set, the price field is set as $15 per dozen for the first two dozen and $13 per dozen for each dozen over two.

Next, create a child class named SpecialCookieOrder, which includes a field with a description as to why the order is special (for example, gluten-free). Override the method that sets a CookieOrder’s price as described in the step above, but also to include special handling, which is $10 for orders up to $40 and $8 for higher-priced orders.

An example of the program is shown below:



Order #101      Arthur         
   type: gluten-free chocolate chip
   1 dozen --- $25
Order #102      Brown          
   type: sugar-free peanut butter
   2 dozen --- $40
Order #103      Cooper         
   type: iced sugar
   3 dozen --- $51



Grading
When you have completed your program, click the Submit button to record your score.