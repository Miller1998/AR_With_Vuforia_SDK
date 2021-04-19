using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataCharacter 
//A namespace is simply a collection of classes that are referred to 
//using a chosen prefix on the class name.
{

    [CreateAssetMenu(fileName = "Character", menuName = "Character/AddNewChracter")]
    public class CharacterDatas : ScriptableObject
    {

        #region Character_BioGraphy
        
        [Header("Character_BioGraphy")]
        public string characterName;
        [TextArea(20, 40)]
        public string characterDes;


        #endregion

    }


}

