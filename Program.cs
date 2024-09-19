Console.OutputEncoding = System.Text.Encoding.UTF8;
int Case = 1;

while (true)
{
    Console.WriteLine($"Case {Case}");
    Console.Write("\t• Input: ");

    string Notification = Console.ReadLine()!;

    string[] DefaultChannels = { "BE", "FE", "QA", "Urgent" };
    string[] Channels = Notification!.Split('[', ']').Where(Value => DefaultChannels.Contains(Value)).ToArray();
    string Channel = String.Join(", ", Channels);

    Console.WriteLine($"\t• Output: Receive channels: {Channel}");

    Console.Write("\nDo you want to reinput? (y/n): ");

    string Reinput = Console.ReadLine()!;
    if (Reinput.Trim().ToLower() != "y")
    {
        break;
    }
    else
    {
        Console.WriteLine();
        Case++;
    }
}