// CS0108: `Derived.Prop' hides inherited member `Base.Prop'. Use the new keyword if hiding was intended
// Line: 10
// Compiler options: -warnaserror -warn:2

class Base {
	public bool Prop = false;
}

class Derived : Base {
	public int Prop {
            get {
                return 0;
            }
        }
}
