using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tekwill_OOP_2024.Lectia5
{
    internal class Lectia5Exercitii
    {

        //Implementarea in Main.. o mica simulare....

        //try
        //{
        //Crearea unui cont de economii (SavingsAccount)
        //SavingAccount savingAccount = new SavingAccount("SA12345", 500m, 0.05m);
        //Console.WriteLine($"Cont economii creat: {savingAccount.accountNumber}, Sold: {savingAccount.balance}, Dobanda: {savingAccount.interesRate * 100}%");

        //Depunere în contul de economii
        //savingAccount.Depozit(200m);
        //Console.WriteLine($"Dupa depunere, sold: {savingAccount.balance}");

        //Retragere din contul de economii
        //savingAccount.Withdraw(100m);
        //Console.WriteLine($"Dupa retragere, sold: {savingAccount.balance}");

        //Crearea unui cont curent (CheckingAccount)
        //CheckingAccount checkingAccount = new CheckingAccount("CA67890", 1000m, 500m);
        //Console.WriteLine($"Cont curent creat: {checkingAccount.accountNumber}, Sold: {checkingAccount.balance}, Limita descoperit: {checkingAccount.overDraftLimit}");

        //Depunere în contul curent
        //checkingAccount.Depozit(300m);
        //Console.WriteLine($"Dupa depunere, sold: {checkingAccount.balance}");

        //Retragere din contul curent sub limit descoperita
        //checkingAccount.Withdraw(1500m);
        //Console.WriteLine($"Dupa retragere, sold: {checkingAccount.balance}");

        //Încercare de retragere peste limita
        //checkingAccount.Withdraw(2000m);
        //}
        //catch (ArgumentException ex)
        //{
        //Console.WriteLine($"Eroare de argument: {ex.Message}");
        //}
        //catch (InvalidOperationException ex)
        //{
        //Console.WriteLine($"Operatiune invalida: {ex.Message}");
        //}
        //catch (Exception ex)
        //{
        //Console.WriteLine($"Eroare neasteptata: {ex.Message}");
        //}
             

            











    }

    public abstract class BankAccount 
    {
        public string accountNumber {get;}
        public decimal balance {  get; protected set; }

        protected BankAccount(string AccountNumber,decimal initialBalance)
        {
            if (initialBalance < 0)
                throw new ArgumentException("Soldul initial nu poate fi negativ.");
            accountNumber = AccountNumber;
            balance = initialBalance;

        }

        //Metodele Abstracte definite...
        public abstract void Depozit(decimal amount);
        public abstract void Withdraw(decimal amount);
    

    }

    public class SavingAccount : BankAccount 
    {
        public decimal interesRate { get; }


        public SavingAccount(string accountNumber, decimal initialBalance, decimal InteresRate) 
        : base(accountNumber, initialBalance)
        {
            if(InteresRate < 0)
                throw new ArgumentException("Rata Dobanzii nu pate fi Negativa");

            interesRate = InteresRate;

        }



        public override void Depozit(decimal amount) 
        {
            if (amount <= 0)
                throw new ArgumentException("Suma depusa trebuie sa fie mai mare decat zero.");
            balance += amount;

        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Suma retrasa trebuie sa fie mai mare decat zero.");
            if (amount > balance)
                throw new InvalidOperationException("Fonduri insuficiente.");
            balance -= amount;

        }



    }

    public class CheckingAccount : BankAccount
    {
        public decimal overDraftLimit { get; }

        public CheckingAccount(string accountNumber , decimal initialBalance , decimal OverDraftLimit) : base(accountNumber, initialBalance)
        {
            if (overDraftLimit < 0)
                throw new ArgumentException("Limita nu poate fi negativa");

            overDraftLimit = OverDraftLimit;
            
        }

        public override void Depozit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Suma depusa trebuie sa fie mai mare decat zero.");
            balance += amount;

        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Suma retrasa trebuie sa fie mai mare decat zero.");
            if (amount > balance + overDraftLimit)
                throw new InvalidOperationException("Depaseste limita descoperita.");
            balance -= amount;



        }

    }








    }
