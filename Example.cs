var account = new Account(privateKey);
var web3 = new Web3(account, $"https://ropsten.infura.io/v3/{projectId}");

ERC721PresetMinterPauserAutoIdService srv = new ERC721PresetMinterPauserAutoIdService(web3, contractAddress);
MintFunction mint = new MintFunction { To = toAddress };

var result = await srv.MintRequestAndWaitForReceiptAsync(mint, null);

Console.WriteLine($"transaction index: {result.TransactionIndex}");
Console.WriteLine($"gas used: {result.GasUsed}");
Console.WriteLine($"status: {result.Status}");
Console.WriteLine(result);