namespace Domain.DTOs.PaymentDto;

public class AddPaymentDto
{
    public int UserId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
}
