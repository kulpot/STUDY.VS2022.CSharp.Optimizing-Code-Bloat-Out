using System;

//ref link:https://www.youtube.com/watch?v=9eZnUk0Gu7M&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=11
//  value type -- ex. char, int, boolean... with its own byte amount
//  reference type -- all reference are same amount of byte
//f10 --> ctrl+alt+d--> Disassembly tab(assembly code)

/*      Disassembly tab(assembly code)    
 *  static void Main()
    {
00007FFBCD7D4400  push        rbp  
00007FFBCD7D4401  push        rdi  
00007FFBCD7D4402  push        rsi  
00007FFBCD7D4403  sub         rsp,30h  
00007FFBCD7D4407  mov         rbp,rsp  
00007FFBCD7D440A  xor         eax,eax  
00007FFBCD7D440C  mov         qword ptr [rbp+28h],rax  
00007FFBCD7D4410  mov         qword ptr [rbp+20h],rax  
00007FFBCD7D4414  cmp         dword ptr [7FFBCD6DAD78h],0  
00007FFBCD7D441B  je          MainClass.Main()+022h (07FFBCD7D4422h)  
00007FFBCD7D441D  call        00007FFC2D2FD410  
00007FFBCD7D4422  nop  
        DoSomething(5); //value type
00007FFBCD7D4423  mov         ecx,5  
00007FFBCD7D4428  call        CLRStub[MethodDescPrestub]@7ffbcd7d3c38 (07FFBCD7D3C38h)  
00007FFBCD7D442D  nop  
        DoSomething('j');   //value type
00007FFBCD7D442E  mov         ecx,6Ah  
00007FFBCD7D4433  call        CLRStub[MethodDescPrestub]@7ffbcd7d3c48 (07FFBCD7D3C48h)  
00007FFBCD7D4438  nop  
        DoSomething(false); //value type
00007FFBCD7D4439  xor         ecx,ecx  
00007FFBCD7D443B  call        CLRStub[MethodDescPrestub]@7ffbcd7d3ff8 (07FFBCD7D3FF8h)  
00007FFBCD7D4440  nop  
        DoSomething(new MainClass());   //reference type
00007FFBCD7D4441  mov         rcx,7FFBCD6DC660h  
00007FFBCD7D444B  call        CORINFO_HELP_NEWSFAST (07FFC2D1DB6A0h)  
00007FFBCD7D4450  mov         qword ptr [rbp+28h],rax  
00007FFBCD7D4454  mov         rcx,qword ptr [rbp+28h]  
00007FFBCD7D4458  call        CLRStub[MethodDescPrestub]@7ffbcd62e3f0 (07FFBCD62E3F0h)  
00007FFBCD7D445D  mov         rdx,qword ptr [rbp+28h]  
00007FFBCD7D4461  mov         rcx,7FFBCD85BFB8h  
00007FFBCD7D446B  call        CLRStub[MethodDescPrestub]@7ffbcd7d4008 (07FFBCD7D4008h)  
00007FFBCD7D4470  nop  
        DoSomething("Hello Dolly"); //reference type
00007FFBCD7D4471  mov         rdx,21D980065C8h  
00007FFBCD7D447B  mov         rdx,qword ptr [rdx]  
00007FFBCD7D447E  mov         rcx,7FFBCD85C040h  
00007FFBCD7D4488  call        CLRStub[MethodDescPrestub]@7ffbcd7d4008 (07FFBCD7D4008h)  
00007FFBCD7D448D  nop  
        DoSomething(new object());  //reference type
00007FFBCD7D448E  mov         rcx,7FFBCD615648h  
00007FFBCD7D4498  call        CORINFO_HELP_NEWSFAST (07FFC2D1DB6A0h)  
00007FFBCD7D449D  mov         qword ptr [rbp+20h],rax  
00007FFBCD7D44A1  mov         rcx,qword ptr [rbp+20h]  
00007FFBCD7D44A5  call        CLRStub[MethodDescPrestub]@7ffbcd620028 (07FFBCD620028h)  
00007FFBCD7D44AA  mov         rdx,qword ptr [rbp+20h]  
00007FFBCD7D44AE  mov         rcx,7FFBCD85C240h  
00007FFBCD7D44B8  call        CLRStub[MethodDescPrestub]@7ffbcd7d4008 (07FFBCD7D4008h)  
00007FFBCD7D44BD  nop  
    }
00007FFBCD7D44BE  nop  
00007FFBCD7D44BF  lea         rsp,[rbp+30h]  
00007FFBCD7D44C3  pop         rsi  
00007FFBCD7D44C4  pop         rdi  
00007FFBCD7D44C5  pop         rbp  
00007FFBCD7D44C6  ret  
00007FFBCD7D44C7  add         byte ptr [rcx],bl  
00007FFBCD7D44C9  or          al,byte ptr [7FFBD4804ED4h]  
00007FFBCD7D44CF  push        rdx  
00007FFBCD7D44D0  add         esp,dword ptr [rax+2]  
00007FFBCD7D44D3  jo          MainClass.Main()+0D6h (07FFBCD7D44D6h)  
00007FFBCD7D44D5  push        rax  
00007FFBCD7D44D6  add         byte ptr [rax],al  
00007FFBCD7D44D8  add         byte ptr [rax],al  
00007FFBCD7D44DA  add         byte ptr [rax],al  
00007FFBCD7D44DC  add         byte ptr [rax],al  
00007FFBCD7D44DE  add         byte ptr [rax],al  
00007FFBCD7D44E0  add         byte ptr [rax],al  
00007FFBCD7D44E2  add         byte ptr [rax],al  
00007FFBCD7D44E4  add         byte ptr [rax],al  
00007FFBCD7D44E6  add         byte ptr [rax],al  
00007FFBCD7D44E8  test        al,67h  
00007FFBCD7D44EA  xchg        cl,ch  
00007FFBCD7D44EC  sti  
00007FFBCD7D44ED  jg          MainClass.Main()+0EFh (07FFBCD7D44EFh)  
00007FFBCD7D44EF  add         byte ptr [rax-7Dh],cl  
00007FFBCD7D44F2  in          al,dx  
00007FFBCD7D44F3  pop         rax  
00007FFBCD7D44F4  xor         eax,eax  
00007FFBCD7D44F6  mov         qword ptr [rsp+28h],rax  
00007FFBCD7D44FB  vxorps      xmm4,xmm4,xmm4  
00007FFBCD7D44FF  vmovdqa     xmmword ptr [rsp+30h],xmm4  
00007FFBCD7D4505  vmovdqa     xmmword ptr [rsp+40h],xmm4  
00007FFBCD7D450B  mov         qword ptr [rsp+50h],rax  
00007FFBCD7D4510  xor         eax,eax  
00007FFBCD7D4512  mov         qword ptr [rsp+40h],rax  
00007FFBCD7D4517  mov         qword ptr [rsp+28h],rcx  
00007FFBCD7D451C  mov         dword ptr [rsp+38h],0FFFFFFFFh  
00007FFBCD7D4524  lea         rcx,[rsp+28h]  
00007FFBCD7D4529  call        CLRStub[MethodDescPrestub]@7ffbcd7d4160 (07FFBCD7D4160h)  
00007FFBCD7D452E  mov         rax,qword ptr [rsp+40h]  
00007FFBCD7D4533  test        rax,rax  
00007FFBCD7D4536  je          MainClass.Main()+013Dh (07FFBCD7D453Dh)  
00007FFBCD7D4538  add         rsp,58h  
00007FFBCD7D453C  ret  
00007FFBCD7D453D  lea         rcx,[rsp+40h]  
00007FFBCD7D4542  call        CLRStub[MethodDescPrestub]@7ffbcd7d4068 (07FFBCD7D4068h)  
00007FFBCD7D4547  jmp         MainClass.Main()+0138h (07FFBCD7D4538h)  
00007FFBCD7D4549  int         3  
00007FFBCD7D454A  int         3  
00007FFBCD7D454B  int         3  
00007FFBCD7D454C  sbb         dword ptr [rcx+rax],eax  
00007FFBCD7D454F  add         byte ptr [rdx],al  
00007FFBCD7D4552  add         byte ptr [rax],al  
00007FFBCD7D4554  add         byte ptr [rax],al  
00007FFBCD7D4556  add         byte ptr [rax],al  
00007FFBCD7D4558  ?? ?????? 
 * 
 */

class MainClass
{
    //static void DoSomething(int arg) { }
    //static void DoSomething(char arg) { }
    //static void DoSomething(bool arg) { }
    //static void DoSomething(MainClass arg) { }
    //static void DoSomething(string arg) { }
    static void DoSomething<T>(T arg) { }
    static void Main()
    {
        DoSomething(5); //value type
        DoSomething('j');   //value type
        DoSomething(false); //value type
        DoSomething(new MainClass());   //reference type
        DoSomething("Hello Dolly"); //reference type
        DoSomething(new object());  //reference type
    }
}