        // 한줄 주석
        /* 
        여러줄 주석
        */
        //alert('Hello, JavaScript!');
        //alert(1+30); // alert + debugging == alerugging
        console.log("Hello, console log");
        var a = true;
        var b = 1;
        console.log(a == b);
        console.log(a === b); //a와 b가 완벽하게 같은지 비교(객체까지 모두 일치해야함)
        let c = 1.5;
        console.log(c);

        var radius = 10;
        const pi = 3.141592;
        //alert('원의 크기는 ' + radius*radius*pi);

        function test() {
            var i = 10;
            return i * pi;
        }
        alert(test());
        var test2 = function() {
            alert('test2');
            alert('함수 선언이 조금 다릅니다.');
        }
        test2();
        
        // 객체 json javascript object notation 
        var product = {
            name: '7D 건조망고',
            type: '당절임류',
            성분: ['망고', '설탕', '메타중아황산나트륨'],
            원산지: '필리핀',
            imported: true,
            price: 5000,
        }

        console.log(product.name);
        console.log(product['name']);
        console.log(product.원산지);

        // c# foreach
        for (var i in product)
        {
            console.log(i + '/' + product[i]);
        }
