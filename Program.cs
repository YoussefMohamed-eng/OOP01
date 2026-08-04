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
            #region Question 02
            ///a) Identify at least three problems with this design from an encapsulation perspective. 
            ////  b) How can private fields and public properties improve this design?
            // solution a
            // 1. All data members are public so they can be modified directly from outside the class
            // 2. There is no validation for values so invalid data can be assigned
            // 3. The class does not protect its internal data making it difficult to maintain data integrity and increasing the chance of bugs
            
            //solution b
            // using private fields and public properties improve encapsulation by :
            // 1. Hiding the internal data from direct access
            // 2. Allowing validation inside properity setters before assigning values
            // 3. preventing invalid data from being stored
            // 4. making the class safer easier to maintain and easier to modify in the future without affecting other parts of the program
            #endregion
    }
    }
}
