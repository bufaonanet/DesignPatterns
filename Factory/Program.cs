using Factory;

FabricaInimigo fabrica = new FabricaInimigo();
Inimigo inimigo1 = fabrica.CriarInimigo("fraco");
Inimigo inimigo2 = fabrica.CriarInimigo("forte");
inimigo1.Atacar(); // Saída: Ataque fraco!
inimigo2.Atacar(); // Saída: Ataque forte!