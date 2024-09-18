
class GetSet
{
    private string _model;

    public string  Model
    {
        get { return _model; }
        set { _model = value; }
    }
}

class Person
{
    Private string _name;

    public string _name
    {
        get{ return _name; }
        set
        {
            If(!string.isNullOrEmpty(value))
            {
                _name = value
            }
        }
    }
}

class Short 
{
    public string Cut { get; set; }
}

class BankAccount
{
    private decimal _balance;

    public decimal _balance
    {
        get{ return _balance; }
        set
        {
            if(value >= 0)
            {
                _balance = value;
            }
        }
    }
}