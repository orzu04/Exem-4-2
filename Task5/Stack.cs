namespace Task5;


public class Stack<T>
{

   List<T> stack = new List<T>();


   public List<T> GetStack()
   {
 
      return stack;
   }


   public void Push(T item)
   {

       stack.Add(item);

   }

   public void Pop()
   {
     
     var pop = stack.Count-1;
     
     
        System.Console.WriteLine(pop); 

}

public void  Peek()
{

       
     var pop = stack.Count-1;
     
     
        System.Console.WriteLine(pop); 


}


}