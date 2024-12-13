using DesafioPOO.Models;

Nokia nokia = new Nokia("(62) 98635-2141", "Nokia A12", "887799664455", 15);

nokia.InstalarAplicativo("Youtube");
nokia.Ligar();
nokia.ReceberLigacao();

Iphone iphone = new Iphone("(61) 98465-2771", "Iphone 16", "5615512315", 23);

iphone.InstalarAplicativo("Youtube");
iphone.Ligar();
iphone.ReceberLigacao();