Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Button1.Visible = False
        MsgBox("有人来了……
躲在某处里的某人望着后面越来越近的影子，紧了紧自己身上的衣服。
那人的影子在月光下越拖越长。
别过来……别过来……
人影像是没有发现他一样，停住了，然后转身往另一个方向走去。
确定那人已经离开，他松了一口气，转过头来，打算起身离开。只听到啊一声，
下一刻，惨叫声划破了夜空。")
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 刷新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刷新ToolStripMenuItem.Click
        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim toppings As String = ""
        If CheckBox2.Checked = True And
            CheckBox5.Checked = True And
            CheckBox9.Checked = True And
            CheckBox11.Checked = True And
            CheckBox1.Checked = False And
            CheckBox3.Checked = False And
            CheckBox4.Checked = False And
            CheckBox6.Checked = False And
            CheckBox7.Checked = False And
            CheckBox8.Checked = False And
            CheckBox10.Checked = False And
            CheckBox12.Checked = False And
            CheckBox13.Checked = False And
            CheckBox14.Checked = False And
            CheckBox15.Checked = False And
            CheckBox16.Checked = False Then
            toppings &= "全部正确"
        Else
            If CheckBox2.Checked = True OrElse CheckBox5.Checked = True OrElse CheckBox9.Checked = True OrElse CheckBox11.Checked = True Then
                toppings &= "部分正确"
            Else
                toppings &= "错误"
            End If
        End If
        If toppings <> "" Then
            MsgBox("您的结果为：" & toppings)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        MsgBox("顷刻间学院后山就挤满了人。
空气里弥漫的血腥味告诉了来人，这里刚刚发生了什么。
腹部被贯穿的紫堂幻靠在树上，镜片碎裂，面带惊恐，身旁还有倒地的三个小斯巴达。
看上去几乎是没有反抗就被杀死的，但看到这一切的人们都没有对此疑惑。
毕竟紫堂幻的实力摆在那里。
没人打算去管这件事，大家很默契的散开了。
格瑞听说紫堂幻被杀后第一件事就是瞒着和紫堂幻同宿舍的金，自己趁夜先去一探究竟。
路上遇到了同样打算去凑个热闹的雷狮。
二人来的时候，紫堂幻还是躺在那里，伤口上的血液几乎快要凝固了。
[有些人为了积分什么都干得出来。]雷狮把自己的想法说了出来，[排名高的不敢动，紫堂幻和你还有那个小子组了那么久的队，积分也不菲。加上实力这么弱……]
[事情没那么简单。]格瑞看着紫堂幻的手势似乎是在保护着什么，便皱了皱眉头。
随即一个微小的动作被他捕捉到了。")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        MsgBox("紫堂幻死亡的消息很快就传遍了整个校园。同宿舍的金更是被一些关注这件事的人推上了风口浪尖。
紫堂幻实力本来就弱，人缘又不好，从头到尾只有金和凯莉以及高年级学长鬼狐天冲他接触过。
而鬼狐天冲这几天都不在校。
凯莉更有同宿舍的安莉洁作证没有出去过。
[祖玛，你怎么看。]雷德凑过去问了问一边的蒙特祖玛。
而蒙特祖玛根本懒得理他，直接转头似是要问嘉德罗斯的意见。
而嘉德罗斯此时的眼中只有对面楼格瑞手上抱着东西走进了金的宿舍。
那个似乎很像是某位已经死去的人的宠物
[呵。]
[走，我们去找格瑞的麻烦去。]")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Visible = False
        MsgBox("人们的猜测被事实推翻了。
金死了，死在了自己的宿舍里。
宿舍的门被嘉德罗斯踹开的那一刻，嘉德罗斯看见的一幕是格瑞看着金久久未动。
金的身体上是一个巨大的窟窿，脸上写满了不可置信。
[格瑞？]
嘉德罗斯识趣地没有把下面的话接上去。
他当然没有把怀疑的目光放在格瑞身上，那么大的窟窿虽然很有可能是烈斩造成的。
但他和格瑞上次打架后烈斩已经被送去寒冰湖修理了，这是嘉德罗斯亲眼看见的。")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Visible = False
        MsgBox("校园里的恐怖气氛越来越浓重了。
格瑞这几天受到了一大群人的异样眼光，唯有同年级的雷狮以及同宿舍的安迷修愿意相信他不是杀了金的凶手。
[我出去一下。]
[慢着，嘉德罗斯说你进金的宿舍的时候有抱着一样东西，方便给我们看一下吗？]
安迷修拉住了正要离开的格瑞。
[好。]
说着格瑞就去自己床榻下找什么东西。
[……谁动过我东西了？]
找了半天，格瑞起身，几乎是以质问的语气对着安迷修和雷狮说的。
[会不会落在金的宿舍里了？]
[安迷修，你先去那边找一下，我马上来。]雷狮在对上格瑞的眼睛的时候就仿佛知道了什么，催着安迷修就是先去找。
安迷修出了门后，便往金的宿舍的反方向去了。
[格瑞？]
格瑞示意让雷狮过来。
雷狮看见的是三个小斯巴达的其中一个，看着格瑞对床安迷修的武器正发抖。")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Visible = False
        MsgBox("雷狮死了，死在学院后山，也就是紫堂幻出事的地方。
没人知道雷狮来这里干什么，只有一旁的卡米尔若有所思。
而前来凑热闹的凯莉在看了看雷狮周围后笑了。
[不需要解释什么吗？]
一旁的安莉洁给了凯莉一样东西，那个看上去像是一条领带。
[最后的骑士……]
[安迷修？]")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Visible = False
        MsgBox("安迷修的罪名算是坐定了。
对于雷狮的死亡安迷修什么也没说，就像是默认是他干的那样。
而凯莉则自请去看管安迷修。
可是不到一天，凯莉和安迷修的尸体都被人发现了。
凯莉和安迷修身上都有被利器明显贯穿的痕迹。
不同的是凯莉的伤口处没有血，反而有些焦黑的痕迹。
[是我干的。]
艾比很干脆地承认了。
[我看不惯那个没马骑士，就杀了他，至于星月魔女，那和我可没有关系。]
一旁的埃米正拉着艾比示意她别乱讲话。")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Visible = False
        MsgBox("卡米尔和格瑞吵起来了。
临走前卡米尔甚至不顾任何人的面子，把门甩上了。
而格瑞的脸上还是那副淡定的表情。
是夜，有人来格瑞宿舍了。
[我不认为是安迷修干的，只是为什么他会去紫堂幻那里？]
[现在不方便说，我可能明天就会死了，我得先去赴约了。]
[？]
[正好可以嫁祸给你，所以，这个藏好。]
格瑞给了来人一张纸条。
[去找莱娜。]")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Visible = False
        MsgBox("格瑞和嘉德罗斯的尸体被发现了。
发现的地点是他俩一直打架的地方。
据雷德和祖玛说，嘉德罗斯发现了断掉的染了血的烈斩。
就什么都没说就去找格瑞了。
[19 15 19]
这是写在烈斩上的字。
[嘿你们看见帕洛斯了吗？]
状况外的佩利这么说道。
[没有。]
[怎么可能，这里确实有帕洛斯的气味啊。]")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button10.Visible = False
        MsgBox("莱娜的尸体在她的宿舍里，大概是晚上死的。
卡米尔发现的。
发现的时候莱娜很虚弱，话语模糊不清。
[救……]
救谁？
卡米尔不知道，他只是看了看手中的东西。
[……]")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Visible = False
        MsgBox("[你给金那小子的东西我还没找到哦。]
[真没想到你居然那么好心。]
[话说觊觎那东西的狐狸也从笼子里逃出去了哦。]
……
[没事， 都死了。]
[你的伤怎么样？]
[被贯穿了非实体而已， 我身后那位就不好了。]")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("以下是本次游戏的提示:
1.紫堂幻有在隐瞒什么东西
2.小斯巴达有一个还活着
3.非实体可以被贯穿
4.凶手有的死了有的活着 不止一个
5.格瑞知道事情的大部分真相。而卡卡也快分析出来了
6.确定无嫌疑的只有卡卡，莱娜
7.安迷修离开格瑞宿舍后去了学院后山 雷狮也是哦
8.cp安艾 玛德
9.黑金不存在，但……
提示按钮将不会隐藏，您可以查看多次。")
    End Sub
    Private Sub 确定查看ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 确定查看ToolStripMenuItem.Click
        MsgBox("来吧我们分 <gong〉析〈bu〉答案。
  看懵了的小天使,
  看完这个你们会更懵233333。")
        MsgBox("第一章：
  这个只是一个经过而已并沒有什么实际性作用。
  紧了紧身上的衣服说明藏着什么东西〈和线索一
  对应〉发生时间在晚上get~")
        MsgBox(" 第二章:
  紫堂幻死了腹部被贯穿(贯穿伤)然后倒地了
  三个小斯巴达。  〈线索中有说到其中一个活着>
  后山挤满了人。
  说明闹出的动静挺大的。
  格瑞瞒着金，遇上了去凑执闹的雷狮。
  这里可以看出来，紫堂幻死前死后，金一直处于
  没有人理睬的状态，并且那么大的动静金也没有
  去询问。所以换句话说，在这个推理里，金目前
  处于生死不明的状态。
  而格瑞雷狮去的时候紫堂幻应该没死多久。
  血液都快要凝固了，应该和某种属性有关。
  顺便格瑞捕捉到的动作，就是线索里提到的小斯
  巴达<而紫堂幻的东西可以根据后文推测出被小
  斯巴达拿了〉。")
        MsgBox("第三章:
此时金依旧没有在众人的视线中出现。而格瑞抱
  着什么东西进了金的宿舍。
  <这个东西依旧是紫堂幻的小斯巴达> 
  重点: 鬼狐天冲这几天不在校。")
        MsgBox("第四章:
 金死了，伤口按照和格瑞打了好几次的嘉嘉来说
  是烈斩造成的。
  脸上不可置信的表情只能说明这个杀了他的是他
  的熟人还是关系特好的那种，或者说是本不该出
  现在这里的。
  联系第二章的生死不明推断，实际是金在紫堂
  幻死之前就已经死了。
  联系发生时间段在晚上，所以极大可能捕捉不到
  那个凶手的面部。
  金唯一能推断凶手是谁的线索只有杀了他的那把
  烈斩，而烈斩所有者是格瑞。
  但是嘉嘉说，烈斩在修复中。
  所以从中推断凶手拥有驱使烈斩的能力，但凶手并非是格瑞本人。
  所以凶手是鬼狐。")
        MsgBox("第五章:
  格瑞理所当然的被众人怀疑了，而安迷修和雷狮
  是信任格瑞的。
  但是与安选修单纯地询问小斯巴达的下落的时候,
  格瑞的表现是质问二人谁动过了他的东西。
  通过下文可以看出来小斯巴达没有丢。
  这个时候格瑞开始怀疑安迷修了，于是他选择支
  开话题。雷狮读的懂格瑞话中的意思，所以帮着
  格瑞一起支开安迷修。
  那么既然雷狮读的懂，和格瑞在一个宿舍那么久的安迷修怎么可能不懂。
  知道二人要支开自己，于是觉得他们在隐瞒什么。
  所以安迷修自行去紫堂幻死的后山先去一探究竟。
  而雷狮看见小斯巴达在看着武器发抖。
  小斯巴达是紫堂幻的战宠，目睹了紫堂幻的死亡。
  结合上文的血液凝固，以此推断，是安迷修的双
  剑之一凝晶造成的紫堂幻身上的贯穿伤。
  故安迷修，鬼狐有嫌疑。
  于是雷狮去后山做的事情就是去比对伤痕，用于
  确认这是否真的是双剑造成的。
  重点:安迷修和雷狮去后山的时间有先后。")
        MsgBox("第六章:
 领带的确是安迷修的，安选修是先去后山的那个。
  而后去后山的雷狮，死了。
  卡米尔只是在思考，为什么雷狮会出现在后山。
  俗话说知道的太多是活不长的，雷狮死于剧情杀/ (开玩笑的>
  虽然没有对雷狮伤口的描写，
  但是通过凯莉她们凭借一条领带就开始怀疑安迷修，
  可以猜测伤口可能也是个贯穿伤之类的。")
        MsgBox("第七章:
  安迷修没有否认去过后山，也没有否认自己杀了雷狮。
  按照安迷修性格来说是就是是不是就是不是。
  也就是说在安迷修的意识之中，
  他确实和雷狮交过手并且给他造成了一定的伤害。
  但是安迷修绝对不可能那么容易就干掉了雷狮，
  因为实力差距。
  加点想象，上文推测的凶手鬼狐复制了雷狮的技
  能去打安迷修，但是安选修没有受伤并反怼了鬼
  狐一下。
  至于为什么雷狮会死，各位往后看。
  看到这里的人是懵的最厉害的。
  凯莉和安哥部挂了。
  凯莉和安哥都受了贯穿伤，而凯莉的伤口有焦黑
  夜迹。
  推测杀了凯莉的是火剑流焱。
  故安迷修，鬼狐有嫌疑。
  至于艾比，那个话和线索cp安艾有联系。
  通过埃米的表现可以看出来艾比在撤谎。
  所以艾比的话没有半毛钱可信度，单纯的只是想
  和安哥一起狗带（殉情）而已。")
        MsgBox("第八章:
  卡卡和格瑞吵起来。
  格瑞表现很淡定。
  通过下文<可以嫁祸给你><我可能明天就要死
  了>可以看出来，晚上去格瑞那的是卡卡，并且
  他们的吵架是故意为之。
  目的就是为了引出凶手，让凶手找上格瑞。
  而格瑞的实力并不弱。
  这时候格瑞让卡卡去找莱娜，并交给了他东西。
  通过线索中格瑞了解大部分真相来说，这个凶手格瑞已经能猜出来是鬼狐了。
  而那个东西就是小斯巴达手上的。
  而此时格瑞提到了<赴约>。")
        MsgBox("第九章:
  格瑞和嘉嘉都挂于同一个地方了。
  经常打架的场地是个误导性线索。
  联系上文赴约，会让你们直接联系到是他俩约互
  相打架。
  实则并不是。
  嘉嘉的到来只是一个巧合，他是捡到了染血的烈
  所，看到上面的信息，才去找格瑞的。
  信息是<191519>
  这里给大家安利一个黑科技，与 你们在同人推理
  里看见1-26之间的数字组成的线索，不要多想这就是26个字母。
  191519对应SOS
  求救，所以嘉嘉以为格瑞遇到了什么事情才去的。
  然后就有人把这俩一锅端了。
  <这里有帕洛斯的气味>
  说明帕洛斯来到过案发现场，联系动面剧情，帕
  帕有黑化的机会。
  所以推测，黑帕约格瑞出来，想解决掉格瑞，正
  好嘉嘉来了。
  于是黑帕一挑二获得胜利。
  <黑化有多牛叉详情参考第一季第三十二集，黑
  金一拳教吸收百人之力的鬼狐做人〉")
        MsgBox("第十章:
  莱娜想要救人。
  <救>这个字第九章也有不过是写在烈斩上的SOS。
  莱娜想要救格瑞吗?
  莱娜想要救的是鬼狐。
  为什么，看最后。")
        MsgBox("第十一章:
  我猜很多人看懵逼了的多半是因为你不知道第十一章讲的究竟是什么。
  我告诉你这个第十一章是两个凶手的对话。
  〈然后你还是不知道对话的两个人是谁〉
  <你给金的那个东西我还没有找到。>
  说明一个凶手给了金一样东西，而出现在整个推
  理里最迷的东西就是最后卡卡手上那玩意。
  而那玩意最初来自于紫堂幻。
  这也就说明了紫堂幻这东西是从金那里拿来的，
  而金是别人给的。
  <没想到你真的那么好心。>
  这句话耳熟吗?我敢保证你听过这句话的另一种
  表述方式一一没想到银爵说的居然是真的。
  是啊这个人是帕帕。")
        MsgBox("<凯觎那东西的狐狸也从笼子里逃走了哦。>
  狐狸很简单，就是指鬼狐。
  联系到鬼狐几天不在校，所以可能是被限制住了
  自己的行动。
  而觊觎那东西也就是鬼狐的杀人动机。
  他先去杀了金，然后惊动了同宿舍的紫堂幻，
  紫堂幻带那玩意跑了，于是他趁夜杀了紫堂幻，结果没找到反而惊动了众人。
  东西被拿走后，他知道会有人过来再查看，于是乎就等着。
  看见安选修来于是和安迷修打没打过。
  然后鬼狐哥哥的下落究竟是什么。
  <都死了。>
  yes都死了。那杀了鬼狐小哥哥的是谁。
  我们见提示最后一个。")
        MsgBox("黑金不存在但是.....
  但是什么?因为说出来会太明显所以我让你们猜啊。
  但是黑化存在啊。黑化存在那黑化的始作俑者就存在啊。
  始作俑者存在,那银爵就存在啊。
  所以杀了鬼狐小哥哥的很明显是我大爵哥。
  那解释的通了，鬼狐，银爵，帕洛斯是两个阵营,
  但是目的相同。
  通过各种地方的推测，银爵把目标放在了去过现
  场的雷狮身上，而帕洛斯则是把目标首先放在了
  格瑞牙上。
  恰巧的是鬼狐把目标放在了正巧来后山的安迷修
  上。
  都是为了找那个东西。
  然后鬼狐复制雷狮技能和安迷修打，重伤跑了。
  银爵则先解决了雷狮。
  帕洛斯则是给格瑞下了个请你来赴约的战书。
  SOS是重伤的鬼狐小哥留下来求救的，然后菜娜要救鬼狐。
  正好此时银爵发现了鬼狐，就和鬼狐打起来了，
  剧情里也存在鬼天盟，所以菜娜虚弱的原因正是
  因为鬼狐吸收了她的力量。
  于是鬼狐GG。")
        MsgBox("而莱娜是因为被鬼狐吸收力量后太过虚弱然后GG。
  看到鬼狐身上的伤猜到鬼狐找过安迷修的银爵，
  让帕洛斯先去解决安迷修。
  而安述修此时和凯莉在一起。
  <贯穿了非实体而已，我身后那位可就不好了。>
  帕帕的技能是暗黑使者，非实体。
  解释到现在谁还没有解决为什么死。
  凯莉，安哥。
  被贯穿的给了特写的只有凯莉，所以简单说明一
  下，杀了凯莉的是安哥。
  但是安哥本不想杀凯莉，只是杀帕洛斯而已。
  安哥刚正面凯莉背后偷袭结果一个剑过去，凯莉
  GG。黑帕安哥打的过吗也不想想，安哥GG。
  然后安哥被反插一剑。
  而帕帕约来的格瑞(格瑞以为对手是鬼狐，结果
  是黑化的帕洛斯)，同时也因为被断掉的烈斩上
  的求救信息而吸引到格瑞身边的嘉德罗斯，二打
  一打不过GG了。")
        MsgBox("而正与帕帕以为，接触过那个东西的人都已经死
  了，那么东西应该在瑞哥身上时。
  瑞哥早有先见之明转移了这个东西。
  那么现在大家是不是有这样一个疑问。
  那个东西究竞是个什么鬼玩意。
  答案一一银爵矿业公司出品的指尖陀螺是也
  本意只是想拔苗助个长，看上了金的煤老板。这个蕴含的力童也被鬼狐看上了。
  于是有了后面一系列的杀人事件。
  综上所述凶手四个
  安迷修→误杀凯莉帮杀鬼狐
  银爵→杀了雷狮，鬼狐
  帕洛斯→杀了格瑞，嘉德罗斯，安迷修
  鬼狐天冲→杀了金，紫堂幻间接杀了菜娜
  线索给你的都是重要的，除了cp那个玛德只是
  我开玩笑写上去的。
  玛德cp全程来秀恩爱的好吗。")
        MsgBox("以上为该谜题的思路和答案。
文案作者:半青不白 版权所有。")
    End Sub

    Private Sub 关于AOTU推理游戏ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于AOTU推理游戏ToolStripMenuItem.Click
        MsgBox("软件作者:雷翎 Lrtray.（半次元:雷翎）
Created By Visual Studio 2017.
文案作者:半青不白（半次元:我似鸽莫得感情的刺客）")
    End Sub

    Private Sub 更新日志ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新日志ToolStripMenuItem.Click
        MsgBox("更新日志:
V1.3
1.重构UI。
2.增加临时文本框，用于记录有用的信息。
V1.2
1.调整窗口大小。
V1.1
1.限制该程序的最大化。
2.调整UI结构。
3.限制:每一章只能查看一次。
V1.0
项目构建。
--------------------------
可能有Bug或者一些错误，欢迎指正。
半次元:@雷翎 Bilibili:@雷家皮皮翎")
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
