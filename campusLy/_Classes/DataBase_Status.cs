public struct DataBase_Status
{
    private string state;
    private string message;

    public DataBase_Status(string state_val, string message_val)
    {
        state = state_val;
        message = message_val;
    }

    internal string getState()
    {
        return state;
    }
    internal string getMessage()
    {
        return message;
    }
    internal void setState(string state_val)
    {
        state = state_val;
    }
    internal void setMessage(string message_val)
    {
        message = message_val;
    }
}