using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeCard : Card
{
    public OrangeCard(CardData pData, typeCard pType) : base(pData, pType)
    {
        data = pData;
        type = pType;
    }

    bool obtained;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Effect()
    {
        if (obtained)
        {
            if (data.nameCard == "Gare")
            {

            }
            if (data.nameCard == "Centre Commercial")
            {

            }
            if (data.nameCard == "Parc d'attractions")
            {

            }
            if (data.nameCard == "Tour radio")
            {

            }
        }
    }
}