using SmartGunBulletManager.IDAL;
using SmartGunBulletManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WMPLib;

namespace SmartGunBulletManager.DAL
{
    public class Player : IPlayer
    {
        WindowsMediaPlayerClass player = null;

        public Player()
        {
            InitPlayer();
        }

        public void InitPlayer()
        {
            player = new WindowsMediaPlayerClass();
            player.uiMode = "None";
            player.settings.volume = 100;
            player.settings.playCount = 1;
        }

        public void LoopMode(bool isLoop)
        {
            player.settings.setMode("loop", isLoop);
        }

        public void Volume(int volume)
        {
            player.settings.volume = volume;
        }

        public void PlaySound(string strMp3Url)
        {
            player.stop();
            player.URL = strMp3Url;
            player.play();
        }
    }
}

#region 属性/方法名： 说明：
//属性/方法名： 说明： 
//[基本属性] 　 
//URL: String; 指定媒体位置，本机或网络地址 
//uiMode:String; 播放器界面模式，可为Full, Mini, None, Invisible 
//playState:integer; 播放状态，1=停止，2=暂停，3=播放，6=正在缓冲，9=正在连接，10=准备就绪 
//enableContextMenu:Boolean; 启用/禁用右键菜单 
//fullScreen:boolean; 是否全屏显示 
//[controls] wmp.controls //播放器基本控制 
//controls.play; 播放 
//controls.pause; 暂停 
//controls.stop; 停止 
//controls.currentPosition:double; 当前进度 
//controls.currentPositionString:string; 当前进度，字符串格式。如“00:23” 
//controls.fastForward; 快进 
//controls.fastReverse; 快退 
//controls.next; 下一曲 
//controls.previous; 上一曲 
//[settings] wmp.settings //播放器基本设置 
//settings.volume:integer; 音量，0-100 
//settings.autoStart:Boolean; 是否自动播放 
//settings.mute:Boolean; 是否静音 
//settings.playCount:integer; 播放次数 
//[currentMedia] wmp.currentMedia //当前媒体属性 
//currentMedia.duration:double; 媒体总长度 
//currentMedia.durationString:string; 媒体总长度，字符串格式。如“03:24” 
//currentMedia.getItemInfo(const string); 获取当前媒体信息"Title"=媒体标题，"Author"=艺术家，"Copyright"=版权信息，"Description"=媒体内容描述，"Duration"=持续时间（秒），"FileSize"=文件大小，"FileType"=文件类型，"sourceURL"=原始地址 
//currentMedia.setItemInfo(const string); 通过属性名设置媒体信息 
//currentMedia.name:string; 同 currentMedia.getItemInfo("Title") 
//[currentPlaylist] wmp.currentPlaylist //当前播放列表属性 
//currentPlaylist.count:integer; 当前播放列表所包含媒体数 
//currentPlaylist.Item[integer]; 获取或设置指定项目媒体信息，其子属性同wmp.currentMedia  
#endregion