public class DynamicArray {
    
    private int _capacity;
    private int _length;
    private int[] _arr;

    public DynamicArray(int capacity) {
        _capacity = capacity;
        _length = 0;
        _arr = new int[_capacity];
    }

    public int Get(int i) {
        return _arr[i];
    }

    public void Set(int i, int n) {
        _arr[i] = n;
    }

    public void PushBack(int n) {
        if (_length == _capacity)
            Resize();

        _arr[_length] = n;
        _length++;
    }

    public int PopBack() {
        if (_length > 0)
            _length--;
        
        return _arr[_length];
    }

    private void Resize() {
        _capacity *= 2;
        int[] newArr = new int[_capacity];

        for(int i = 0; i < _arr.Length; i++)
        {
            newArr[i] = _arr[i];
        }
        _arr = newArr;
    }

    public int GetSize() {
        return _length;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
