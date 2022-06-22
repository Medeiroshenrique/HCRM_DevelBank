﻿class Conta
{
    private int _numAccount;
    private string _userName;
    private double _balance;
    private double _initialDeposit;
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
            _balance = _initialDeposit;
        }
    }
    void Deposit(double DepositValue)
    {
        _balance+=DepositValue;
    }
    void Withdraw(double DepositValue)
    {
        _balance -= DepositValue;
    }
}