using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

namespace Story
{
    [CreateNodeMenu("对话")]
    [NodeWidth(200)]
    [NodeTitle("对话")]
    public class TalkNode:StoryBaseNode
    {
        [Input]
        public StoryBaseNode input;
        [Output(backingValue = ShowBackingValue.Never,connectionType = ConnectionType.Override,dynamicPortList =true)]
        public List<ChatData> chats = new List<ChatData>();
    }

    [System.Serializable]
    public class ChatData 
    {
        public string Name;
        public string Content;
    }
}
