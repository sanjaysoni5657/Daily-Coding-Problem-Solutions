public class Singleton {
  private static Singleton evenInstance;
  private static Singleton oddInstance;
  
  private int counter = 0;
  
  private Singleton(){
    // some initialization code
  }

  private static Singleton getEvenInstance() {
      if(evenInstance == null) {
        evenInstance = new Singleton();
      }
      return evenInstance;
  }

  private static Singleton getOddInstance() {
      if(oddInstance == null) {
        oddInstance = new Singleton();
      }
      return oddInstance;
  }

  public static Singleton getInstance() {
    counter++;
    return counter%2 == 0 ? getEvenInstance() : getOddInstance();
  }
  
}
