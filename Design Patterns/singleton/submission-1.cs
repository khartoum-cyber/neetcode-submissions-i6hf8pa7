public class Singleton {

    private static Singleton _instance;
    private static string _value;

    private Singleton() {
      
    }

    public static Singleton getInstance() {
        if(_instance == null)
            _instance = new Singleton();
        return _instance;
    }

    public string getValue() {
        return _value;
    }

    public void setValue(string value){
        _value = value;
    }
}
