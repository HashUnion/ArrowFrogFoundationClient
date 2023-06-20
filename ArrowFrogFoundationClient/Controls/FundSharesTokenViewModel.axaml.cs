using ReactiveUI;

namespace ArrowFrogFoundationClient.ViewModels;

public class FundSharesTokenViewModel : ReactiveObject
{
    private string _fundSharesTokenAddress = "0x714Fbd78C8eEdf4F7f499E866c1C90d0E157a16D";

    public string FundSharesTokenAddress
    {
        get => _fundSharesTokenAddress;
        set => this.RaiseAndSetIfChanged(ref _fundSharesTokenAddress, value);
    }
    private string _newFundSharesTokenAddress = "";

    public string NewFundSharesTokenAddress
    {
        get => _newFundSharesTokenAddress;
        set => this.RaiseAndSetIfChanged(ref _newFundSharesTokenAddress, value);
    }

    public void SubmitFundSharesTokenAddress()
    {
        FundSharesTokenAddress = NewFundSharesTokenAddress;
    }
}