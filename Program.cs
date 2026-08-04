namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
          ///a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified? 
          ///  b) What happens when a Customer variable is copied into another variable and one variable modifies the object?
          //Solution a
          //when you copy one DeliveryAddress variable to another a new copy of data is created if you modify the copied variable the original variable remains unchanged
          //because The DeliveryAddress is Struct and struct is value type

          //solution b
          //when you copy a customer variable both variables refer to the same object in momery if  one variable modifies the object the change is visible
          //through the other variable as well
          //because Customer is a class and classes are Reference types
            #endregion
        }
    }
}
