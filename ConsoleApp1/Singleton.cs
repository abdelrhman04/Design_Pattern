namespace DesignPatterns;
public class Singleton
{
    public int count = 0;
    private static Singleton instance = null;
    private static object lockobj = new object();
    private Singleton() { }
    public static Singleton GetInstance(){
        //Lazy Initialization
        if (instance == null) { 
            lock (lockobj)
                {
                   instance = new Singleton();
                }
        }
        return instance;
    }
public void Addone() => count++;
}