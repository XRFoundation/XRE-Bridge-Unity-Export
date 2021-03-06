using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace XREngine.XRProject
{
    public class SpawnPoint : RPComponent
    {
        public override string Type => base.Type + ".spawn-point";

        public override JProperty Serialized => new JProperty("extras", new JObject(
            new JProperty(Type, new JObject()),
            new JProperty("xrproject.entity", transform.name)
        ));
    }

}
