var map = new AMap.Map('container',{resizeEnable: true});
	    
        var markers = []; //province见Demo引用的JS文件
        for (var i = 0; i < devices.length; i += 1) {
    			var marker;
    			//污水图标
    			if (devices[i].type === 0) {
    				var icon = new AMap.Icon({
    					//size: new AMap.Size(19, 33),
    					image: './img/mark_bs1.png',
    					size: new AMap.Size(19, 33),
    					imageSize: new AMap.Size(19, 33)
    				});
    				marker = new AMap.Marker({
    					icon: icon,
    					position: devices[i].center.split(','),
    					offset: new AMap.Pixel(-12,-12),
    					zIndex: 101,
    					title: devices[i].name,
    					map: map
    				});
    			}else if (devices[i].type === 2) {//设备故障报警
      				var content= "<a href='https://www.baidu.com/'><img src='./img/mark_bs2.png' style='width: 19px; height: 33px;' /></a>";
      				baodao = new AMap.Marker({
      					content: content,
      					position: devices[i].center.split(','),
      					title: devices[i].name,
      					offset: new AMap.Pixel(0,0),
      					map: map
      				});
	            }else {//二次供水
	    				var content= "<img src='./img/mark_bs.png' style='width: 19px; height: 33px;' />";
	    				marker = new AMap.Marker({
	    					content: content,
	    					position: devices[i].center.split(','),
	    					title: devices[i].name,
	    					map: map
	    				});
	    			}
    			markers.push(marker);
    		}
//			  map.setFitView();
			  //地图初始加载定位到当前城市
			  map.plugin(['AMap.ToolBar'], function() {
			      //设置地位标记为自定义标记
			      var toolBar = new AMap.ToolBar();
			      map.addControl(toolBar);
			  });