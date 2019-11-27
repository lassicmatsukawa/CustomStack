## CustomStack

### LICENSE

MIT

### usecase

#### push to over limit

when stack limit is 3

```
            stack = new StackExample<SampleData>();
            var taro   = new SampleData("Taro");
            var hanako = new SampleData("Hanako");
            var jiro   = new SampleData("Jiro");
            var yoko   = new SampleData("Yoko");
            var saburo = new SampleData("Saburo");

            stack.Push(taro);
            stack.Push(hanako);
            stack.Push(jiro);
            stack.Push(yoko);
            stack.Push(saburo);
```

```
<------------------->
Taro
<------------------->
<------------------->
Taro
Hanako
<------------------->
<------------------->
Taro
Hanako
Jiro
<------------------->
<------------------->
Hanako
Jiro
Yoko
<------------------->
<------------------->
Jiro
Yoko
Saburo
<------------------->
```

#### delete specific index

```
            stack = new StackExample<SampleData>();

            stack.Push(taro);
            stack.Push(hanako);
            stack.Push(jiro);
            stack.Remove(2);
            stack.Remove(1);
            stack.Remove(2);
```

```
<------------------->
Taro
<------------------->
<------------------->
Taro
Hanako
<------------------->
<------------------->
Taro
Hanako
Jiro
<------------------->
<------------------->
Taro
Hanako
<------------------->
<------------------->
Taro
<------------------->
<------------------->
Taro
<------------------->
```

#### pop item(element)

```
            stack = new StackExample<SampleData>();

            stack.Push(taro);
            stack.Push(hanako);
            var item = stack.Pop();
            Console.WriteLine(item.Name);
            item = stack.Pop();
            Console.WriteLine(item.Name);
            item = stack.Pop();
            try
            {
                Console.WriteLine(item.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("it's unsafe - {0}", ex.Message);
            }
```

```
<------------------->
Taro
<------------------->
<------------------->
Taro
Hanako
<------------------->
Hanako
Taro
it's unsafe - オブジェクト参照がオブジェクト インスタンスに設定されていません。
```
