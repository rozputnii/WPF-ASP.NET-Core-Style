using System;

namespace Services.Default
{
	internal sealed class SomeService : ISomeService
	{
		public string GetName() => Guid.NewGuid().ToString();
    }
}
