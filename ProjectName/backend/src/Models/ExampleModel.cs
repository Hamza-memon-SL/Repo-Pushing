public class ExampleModel
{
    public static bool EOF { get; set; } = false;
}

using System;

namespace ProjectName.Backend.Models
{
    public class ErrorRecord
    {
        public TransactionRecord TransRecord { get; set; }
        public string ErrorMessage { get; set; }
    }
}

public class ErrorRecord
{
    public TransactionRecord TransRecord { get; set; }
    public string ErrorMessage { get; set; }

    // Constructor
    // Initializes an ErrorRecord instance with a transaction record and error message.
    public ErrorRecord(TransactionRecord transRecord, string errorMessage)
    {
        this.TransRecord = transRecord;
        this.ErrorMessage = errorMessage;
    }
}

public class ExampleModel
{
    public int Id { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public string TransactionType { get; set; }
    public string Description { get; set; }
}

public class ExampleModel
{
    public int Id { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
}

public class TransactionRecord
{
    public int Id { get; set; }
    public DateTime TransactionDate { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }

    // Constructor to initialize the TransactionRecord with key properties.
    public TransactionRecord(int id, DateTime transactionDate, decimal amount, string description)
    {
        Id = id;
        TransactionDate = transactionDate;
        Amount = amount;
        Description = description;
    }
}

public class ExampleModel
{
    public string Message { get; set; }
    public string StackTrace { get; set; }
    public string Timestamp { get; set; }
}

namespace BipolarProject.Services
{
    public class Module2Service
    {
        private readonly ILogger<Module2Service> _logger;

        public Module2Service(ILogger<Module2Service> logger)
        {
            _logger = logger;
        }
    }
}

public class TransactionRequest
{
    public string Sender { get; set; }
    public string Receiver { get; set; }
    public decimal Amount { get; set; }
}

public class ErrorRecord
{
    public int Code { get; set; }
    public string Message { get; set; }
}

public static class TransactionIdGenerator
{
    public static string Generate(TransactionRequest request)
    {
        return Guid.NewGuid().ToString();
    }
}

public class PremiumCalculationRequest
{
    public decimal WsAmountUsd { get; set; }
    public decimal WsExpenseRatio { get; set; }
    public decimal WsProfitRatio { get; set; }
    public decimal WsRiskRatio { get; set; }
    public decimal WsReinsCost { get; set; }
}

public class PremiumCalculationResponse
{
    public decimal WsPurePremium { get; set; }
    public decimal WsExpenseLoading { get; set; }
    public decimal WsProfitMargin { get; set; }
    public decimal WsRiskMargin { get; set; }
    public decimal WsGrossPremium { get; set; }
}

