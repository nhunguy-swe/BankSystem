using BankAccountNS;

namespace BankTests;

[TestClass]
public class BankAccountTests {
    
    [TestMethod]
    public void Debit_WithValidAmount_UpdatesBalance() {
        
// Arrange (Chuẩn bị)
        double beginningBalance = 11.99; 
        double debitAmount = 4.55; 
        double expected = 7.44;
        BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);
        
// Act (Thực hiện)
        account.Debit(debitAmount);
        
// Assert (Kiểm tra kết quả)
        double actual = account.Balance;
        Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
    }
}