using System.Collections;
using Arion.NodeTypes;

namespace Arion; 

public class CodeGenerator {
    public static void GenerateCode(List<ExecuteableCode> executeableCode) {
        foreach (var ec in executeableCode) {
            ec.Run();
        }
    }
}