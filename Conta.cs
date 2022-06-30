class Conta
{
    private int _numAccount;
    private string _userName;
    private double _balance;
    private double _initialDeposit;
    private string _password;
    public int NumAccount
    {
        get { return _numAccount; }
        set {
            _numAccount = value;
        }
    }
    public string UserName
    {
        get { return _userName; }
        set {
            if (value != null && value.Length > 0) {
                _userName = value;
            }
        }
    }
    public double Balance {
        get { return _balance; }
        set { _balance = value; }
    }
    public double InitialDeposit
    {
        get { return _initialDeposit; }
        set { _initialDeposit = value;
            Deposit(_initialDeposit);
        }
    }
    public void Deposit(double DepositValue)
    {
        _balance+=DepositValue;
    }
    public void Withdraw(double WithdrawValue)
    {if (WithdrawValue != 0) {
            _balance -= (WithdrawValue + 5);
        }
        else {}
        
    }
    public void Password(string password) {
        if (password!=null && password.Length>7){
            _password = password;
        }
        }
}