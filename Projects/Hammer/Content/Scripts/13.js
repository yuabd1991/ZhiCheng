$(document).ready(function () {
	//���˵�
	$("ul#menu>li:has(dt)").hover(
	  function () {
	  	$(this).children('a').addClass('red').end().find('dd').fadeIn(400);
	  },
	  function () {
	  	$(this).children('a').removeClass('red').end().find('dd').fadeOut(400);
	  }
	);

	//��ҳ�õ�Ƭ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
//	var sWidth = $("#focus").width(); //��ȡ����ͼ�Ŀ�ȣ���ʾ�����
//	var len = $("#focus ul li").length; //��ȡ����ͼ����
//	var index = 0;
//	var picTimer;

	//���´���������ְ�ť�Ͱ�ť��İ�͸������������һҳ����һҳ������ť
//	var btn = "<div class='btnBg'></div><div class='btn'>";
//	for (var i = 0; i < len; i++) { btn += "<span></span>"; }
//	btn += "</div>";
//	$("#focus").append(btn);
//	$("#focus .btnBg").css("opacity", 0.5);

	//ΪС��ť�����껬���¼�������ʾ��Ӧ������
//	$("#focus .btn span").css("opacity", 0.4).mouseenter(function () {
//		index = $("#focus .btn span").index(this);
//		showPics(index);
//	}).eq(0).trigger("mouseenter");
	//����Ϊ���ҹ�����������liԪ�ض�����ͬһ�����󸡶�������������Ҫ�������ΧulԪ�صĿ��
//	$("#focus ul").css("width", sWidth * (len));
//	//��껬�Ͻ���ͼʱֹͣ�Զ����ţ�����ʱ��ʼ�Զ�����
//	$("#focus").hover(function () { clearInterval(picTimer); }, function () {
//		picTimer = setInterval(function () { showPics(index); index++; if (index == len) { index = 0; } }, 4000); //��4000�����Զ����ŵļ������λ������
//	}).trigger("mouseleave");

	//��ʾͼƬ���������ݽ��յ�indexֵ��ʾ��Ӧ������
//	function showPics(index) { //��ͨ�л�
//		var nowLeft = -index * sWidth; //����indexֵ����ulԪ�ص�leftֵ
//		$("#focus ul").stop(true, false).animate({ "left": nowLeft }, 300); //ͨ��animate()����ulԪ�ع������������position
//		//$("#focus .btn span").removeClass("on").eq(index).addClass("on"); //Ϊ��ǰ�İ�ť�л���ѡ�е�Ч��
//		$("#focus .btn span").stop(true, false).animate({ "opacity": "0.4" }, 300).eq(index).stop(true, false).animate({ "opacity": "1" }, 300); //Ϊ��ǰ�İ�ť�л���ѡ�е�Ч��
//	}
	//��ҳ�õ�Ƭ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------


	//���š���ҵ������ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	var msn = msn || {};
	msn.hp = msn.hp || {};
	msn.hp.tab = {
		t: null,
		delayTime: 150,
		fx: true,
		tab: function (b) {
			$(b).siblings().removeClass("on");
			$(b).addClass("on");
			var c = $(b).parents(".tab").find("div.t");
			var a = c.eq($(b).index());
			c.addClass("none");
			a.removeClass("none");
			if (this.fx) {
				if ($(b).parent().hasClass("nofx")) {
					return
				}
				$(b).parent().siblings(".animate").width($(b).outerWidth() - 2).animate({
					left: $(b).position().left
				},
            "slow")
			}
		},
		delayTab: function (b, a) {
			clearTimeout(b.t);
			this.t = setTimeout(function () {
				b.tab(a)
			},
        this.delayTime)
		},
		init: function () {
			var a = this;
			a.animate();
			if (window.Touch) {
				$(".tab .main_title>ul>li[class!='on']>a").click(function () {
					return false
				})
			}
			$(".tab .main_title>ul>li,.tab>ul.hotread_menu>li").hover(function () {
				a.delayTab(a, this)
			},
        function () {
        	clearTimeout(a.t)
        })
		},
		animate: function () {
			if (!this.fx) {
				return
			}
			$(".tab .main_title>ul").each(function () {
				if (!$(this).hasClass("nofx")) {
					$(this).addClass("fx")
				}
			});
			$(".tab .main_title").each(function (a, b) {
				if ($(this).find("ul").hasClass("nofx")) {
					return
				}
				$(b).append("<div class='animate' ></div>");
				$(b).find(".animate").width($(b).find("ul>li.on").outerWidth() - 2).css("left", $(b).find("ul>li.on").position().left)
			})
		}
	};

	var a = msn.hp;
	a.tab.init();
	//���š���ҵ������ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//��ҳ�Żݻ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$(".fd_list dt a").mousemove(function () {
		$(".fd_list dd").css("display", "none");
		$(".fd_list dt").removeClass("open");
		$(this).parent("dt").next("dd").css("display", "block");
		$(this).parent("dt").addClass("open");
		return false;
	})
	//��ҳ�Żݻ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//רҵ���� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#zyjq").organicTabs({ "speed": 200 });
	//רҵ���� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------


	//��Ӱרҵ ��ױרҵ ����רҵ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#warpsub").organicTabs({ "speed": 100 });
	//��Ӱרҵ ��ױרҵ ����רҵ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//�ȵ����� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#rdph").organicTabs({ "speed": 100 });
	//�ȵ����� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------


	//ȫ���γ̺͹������� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#Allkc").organicTabs({ "speed": 200 });
	//ȫ���γ̺͹������� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//��ϵ������ҳ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#acontact").organicTabs({ "speed": 200 });
	//��ϵ������ҳ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//��ʦ���� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#msjt").organicTabs({ "speed": 200 });
	//��ʦ���� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//������Ϣ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#zsjz").organicTabs({ "speed": 200 });
	//������Ϣ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//�γ̽׶� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#jd").organicTabs({ "speed": 200 });
	//�γ̽׶� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//�γ̽׶� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#SchoolOverview").organicTabs({ "speed": 200 });
	//�γ̽׶� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//�γ̽׶� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$("#SchoolE").organicTabs({ "speed": 200 });
	//�γ̽׶� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//��ǰλ���·�ͼƬ�ֻ� {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	//$('#change_1 .a_bigImg').soChange();
	//��ǰλ���·�ͼƬ�ֻ� }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------


	//������ҳ {{{{{{{{{{{{{{{{{{{{{{---------------------------------------
	$(window).scroll(function () { var top = $(window).scrollTop(); if (top > 500) { $("#scrolltop").fadeIn(); } else { $("#scrolltop").fadeOut(); } }); //�������ͷ��Ч��
	$("#scrolltop").click(function () { $("html,body").animate({ scrollTop: 0 }); });
	//������ҳ }}}}}}}}}}}}}}}}}}}}}}}}}}-----------------------------------

	//��Ӱרҵ - ��ױ��ʦ
	//$(".hzms li .img img,.hzzp li .img img").mouseover(function(){
	//    $(this).css({opacity: 0.5});
	//    $(this).animate({'opacity': 1}, "slow");//�Ӵ�ʱ��ʾ��ɫ���ٶ��磺��normal����fast����slow�����루���� 1500��
	//  });
	//  $(".hzms li .img img,.hzzp li .img img").mouseout(function(){
	//    $(this).css({opacity: 1});
	//    $(this).animate({'opacity': 0.5},"slow");//�Ӵ�ʱ��ʾ��ɫ���ٶ��磺��normal����fast����slow�����루���� 1500��
	//  });

});