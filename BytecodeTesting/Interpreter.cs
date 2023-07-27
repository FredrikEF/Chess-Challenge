namespace BytecodeTesting;

public class Interpreter
{
    //NOP   0
    //LOAD  1 reg[a] = code[reg[b]*4]
    //STORE 2 code[reg[b]*4] = reg[a]
    //ADD   3 
    //SUB   4
    //AND   5
    //      6
    //      7

    //3 bit op 5 bit data

    int[] regs = new int[1024];
    int pc;
    ulong[] code = new[]
    {
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU,
        0b00000000_00000000_00000000_00000000_00000000_00000000_00000000_00000000LU
    };


    int store(int a, int b)
        => (int)(code[b >> 1] = code[b >> 1] & (0xffffffff00000000UL >> 32 * (b & 1)) | ((ulong)a << 32*(1-b&1)));

    int load(int b)
        => (int)((code[b >> 1] >> 32 * (1 - b & 1)) & 0xffffffffUL);

    public int Eval()
    {
        while (regs[0] > 0)
        {
            pc = regs[0];
            var instruction = code[pc >> 3];
            instruction >>= (pc & 7) * 8;
            ulong a = instruction & 0b00011000 >> 3, b = instruction & 0b00000110 >> 1;
            _ = (instruction & 0b11100000000UL) switch
            {
                1 => regs[a] = load(regs[b]),
                2 => store(regs[a], regs[b]),
                3 => regs[a] += regs[b],
                4 => regs[a] -= regs[b],
                5 => regs[a] &= regs[b],

                _ => 0
            };
        }
        return 0;
    }



}

