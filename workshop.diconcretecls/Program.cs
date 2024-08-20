//example 1 - di concrete injection
workshop.diconcretecls.ConstructorInject.AddEngine engine1 = new workshop.diconcretecls.ConstructorInject.AddEngine();
workshop.diconcretecls.ConstructorInject.Calculator calculator1 = new workshop.diconcretecls.ConstructorInject.Calculator(engine1);
int a = 2;
int b = 3;
int result = calculator1.Add(a, b);






//example 2 - di concrete injection
int aa = 12;
int bb = 3;
workshop.diconcretecls.ConstructorInject2.CalculationEngine engine2 = new workshop.diconcretecls.ConstructorInject2.CalculationEngine();
workshop.diconcretecls.ConstructorInject2.Calculator calculator2 = new workshop.diconcretecls.ConstructorInject2.Calculator(engine2);
Console.WriteLine(calculator2.Calculate(aa, bb));




//example 3 - di method injection
int aaa = 4;
int bbb = 5;
workshop.diconcretecls.MethodInject.MultiplyEngine engine3 = new workshop.diconcretecls.MethodInject.MultiplyEngine();
workshop.diconcretecls.MethodInject.Calculator calculator3 = new workshop.diconcretecls.MethodInject.Calculator();
Console.WriteLine(calculator3.Multiply(aaa, bbb, engine3));




//example 4 - di property injection
int aaaa = 4;
int bbbb = 4;
workshop.diconcretecls.PropertyInject.CalculatorEngineForAdding calculatorEngineForAdding = new workshop.diconcretecls.PropertyInject.CalculatorEngineForAdding();
workshop.diconcretecls.PropertyInject.Calculator calculator4 = new workshop.diconcretecls.PropertyInject.Calculator();
calculator4.CalculatorEngineForAdding = calculatorEngineForAdding;
Console.WriteLine(calculator4.Add(aaaa, bbbb));


