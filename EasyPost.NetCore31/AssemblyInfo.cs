﻿using System.Runtime.CompilerServices;

// Make "private" methods testable.
#if DEBUG
[assembly: InternalsVisibleTo("EasyPost.NetCoreTest")]
#else
[assembly: InternalsVisibleTo("EasyPost.NetCoreTest, PublicKey=0024000004800000140100000602000000240000525341310008000001000100d99de7efe2414581cc393618c44a1a5664f8e3ea301a4bdc84d82cdbdbdd248ebdd3a2a2ddb2e915558780429b85e3d763883f02a70f3ca365122d62af0eadc86f69c50648953a1a04f4dcd4811b174c407e85c6029cc8c0212671a25edd76ba215fb5704308b9bc2dc20d6858a9eda35895ca2d0194de248081c030bb0dc6149ac206faca5af694f582540b6c6a066cda20bf0d89adbd3eba0e66b5e304c18c540cf451597075773f728ce392710cfa91a568cc26f9274e7b5dfb588a3890916384b9e2a700c678732f693c85c81f94d30aa6b4ce2185b43cbc6fee679a6f0c020a7bf70589a80a6d6a890298ca10a8d213567528c79192a061c6df7bc61ab6")]
#endif