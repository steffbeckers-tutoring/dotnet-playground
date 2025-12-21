namespace Playground.ClassLibrary.ProgrammingAdvancedCup;

public class Wimbledon
{
    public string Decrypt(string encryptedMessage)
    {
        string decryptedMessage = string.Empty;

        int indexFromStart = 0;
        int indexFromEnd = encryptedMessage.Length - 1;
        bool fromStart = true;

        while (decryptedMessage.Length != encryptedMessage.Length)
        {
            if (fromStart)
            {
                decryptedMessage += encryptedMessage[indexFromStart];
                indexFromStart++;
            }
            else
            {
                decryptedMessage += encryptedMessage[indexFromEnd];
                indexFromEnd--;
            }

            fromStart = !fromStart;
        }

        return decryptedMessage;
    }
}
