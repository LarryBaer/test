namespace Arion.NodeTypes.Statements; 

public class If : ExecuteableCode {
    private List<ExecuteableCode> ec_;
    public bool boolean;

    public If(List<ExecuteableCode> ec) {
        ec_ = ec;
    }
    public void Run() {
        // Console.WriteLine("ENTERED IF RUN" + boolean);
        // INSTEAD OF A BOOLEAN, PUT AN EXPRESSION IN HERE. THEN, EVALUATE THE EXPRESSION !
        if (boolean) {
            // Console.WriteLine("ENTERED IF RUN IF");
            foreach (var executeableCode in ec_) {
                executeableCode.Run();
            }
        }
    }
}