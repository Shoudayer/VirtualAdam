# VirtualAdam
Virtual Adam 4050 and 4017 from Advantech 

This version only responds to :

"$AA2(cr)" for configuration state of each module.
"#AA(cr)" read input data (4017).
"$AA6(cr) " read input and output data (4050).

         AA -> module address (with two hexadecimal  char (0-FF) )
        (cr) -> '\r' a carriage return must be send after every command
        
This program  must be use with a Null-modem emulator like [com0com] [https://sourceforge.net/projects/com0com/?SetFreedomCookie] 
