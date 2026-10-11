namespace Refatoracao;

public class OrderProcessor
{
    private readonly Validation _validation;
    private readonly Calculator _calculator;
    private readonly Repository _repository;
    private readonly Email _email;
    private readonly Receipt _receipt;

    public OrderProcessor(
        Validation validation,
        Calculator calculater,
        Repository repository,
        Email email,
        Receipt receipt)
    {
        _validation = validation;
        _calculator = calculater;
        _repository = repository;
        _email = email;
        _receipt = receipt;
    }

    public void Process(Order order)
    {
        _validation.Validate(order);
        _calculator.Calculate(order);
        _repository.Save(order);
        _email.Send(order);
        _receipt.ProvideReceipt(order);
    }
}