#asp.net web: 1-razorpage  2-Mvc 3-blazor
1/2都是属于服务器型，3属于客户端型。
1在page里的每个.cshtml下又分别对应了.cs文件来处理相应的action。
而2处理action逻辑是在各个controller.cs中。 其余部分基本类似，大同小异
3在razor（ui）里就可以写逻辑，而且可以实现razor复用，一个razor可以包含另一个razor实现功能，这一点很方便
