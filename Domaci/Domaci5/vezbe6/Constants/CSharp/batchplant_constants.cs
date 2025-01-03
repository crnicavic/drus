namespace BatchPlant.WebApi
{
    /// <summary>
    /// The namespaces used in the model.
    /// </summary>
    public static class Namespaces
    {
        /// <remarks />
        public const string Uri = "http://opcfoundation.org/BatchPlant";
    }

    /// <summary>
    /// The browse names defined in the model.
    /// </summary>
    public static class BrowseNames
    {
        /// <remarks />
        public const string BatchPlant1 = "Batch Plant #1";
        /// <remarks />
        public const string BatchPlantType = "BatchPlantType";
        /// <remarks />
        public const string Conveyor = "ConveyorX001";
        /// <remarks />
        public const string ConveyorMotor = "Motor02";
        /// <remarks />
        public const string ConveyorMotorType = "ConveyorMotorType";
        /// <remarks />
        public const string ConveyorType = "ConveyorType";
        /// <remarks />
        public const string ExcitationVoltage = "ExcitationVoltage";
        /// <remarks />
        public const string GenericActuatorType = "GenericActuatorType";
        /// <remarks />
        public const string GenericMotorType = "GenericMotorType";
        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";
        /// <remarks />
        public const string Input = "Input";
        /// <remarks />
        public const string LevelIndicatorType = "LevelIndicatorType";
        /// <remarks />
        public const string LoadcellTransmitter = "LT001";
        /// <remarks />
        public const string LoadcellTransmitterType = "LoadcellTransmitterType";
        /// <remarks />
        public const string Mixer = "MixerX001";
        /// <remarks />
        public const string MixerDischargeValve = "Valve004";
        /// <remarks />
        public const string MixerMotor = "Motor01";
        /// <remarks />
        public const string MixerMotorType = "MixerMotorType";
        /// <remarks />
        public const string MixerType = "MixerType";
        /// <remarks />
        public const string Output = "Output";
        /// <remarks />
        public const string PackagingUnit = "PackagingUnitX001";
        /// <remarks />
        public const string PackagingUnitLevelIndicator = "LI004";
        /// <remarks />
        public const string PackagingUnitType = "PackagingUnitType";
        /// <remarks />
        public const string RadeKoncarMotor = "Motor03";
        /// <remarks />
        public const string RadeKoncarMotorType = "RadeKoncarMotorType";
        /// <remarks />
        public const string Silo1 = "SiloX001";
        /// <remarks />
        public const string Silo1DischargeValve = "Valve001";
        /// <remarks />
        public const string Silo1LevelIndicator = "LI001";
        /// <remarks />
        public const string Silo1Type = "Silo1Type";
        /// <remarks />
        public const string Silo2 = "SiloX002";
        /// <remarks />
        public const string Silo2DischargeValve = "Valve002";
        /// <remarks />
        public const string Silo2LevelIndicator = "LI002";
        /// <remarks />
        public const string Silo2Type = "Silo2Type";
        /// <remarks />
        public const string Silo3 = "SiloX003";
        /// <remarks />
        public const string Silo3DischargeValve = "Valve003";
        /// <remarks />
        public const string Silo3LevelIndicator = "LI003";
        /// <remarks />
        public const string Silo3Type = "Silo3Type";
        /// <remarks />
        public const string Speed = "Speed";
        /// <remarks />
        public const string StartProcess = "StartProcess";
        /// <remarks />
        public const string StopProcess = "StopProcess";
        /// <remarks />
        public const string Units = "Units";
        /// <remarks />
        public const string ValveType = "ValveType";
    }

    /// <summary>
    /// The well known identifiers for Method nodes.
    /// </summary>
    public static class MethodIds {
        /// <remarks />
        public const string BatchPlantType_StartProcess = "nsu=" + Namespaces.Uri + ";i=285";
        /// <remarks />
        public const string BatchPlantType_StopProcess = "nsu=" + Namespaces.Uri + ";i=286";
        /// <remarks />
        public const string BatchPlant1_StartProcess = "nsu=" + Namespaces.Uri + ";i=414";
        /// <remarks />
        public const string BatchPlant1_StopProcess = "nsu=" + Namespaces.Uri + ";i=415";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(MethodIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Object nodes.
    /// </summary>
    public static class ObjectIds {
        /// <remarks />
        public const string Silo1Type_Silo1LevelIndicator = "nsu=" + Namespaces.Uri + ";i=41";
        /// <remarks />
        public const string Silo1Type_Silo1DischargeValve = "nsu=" + Namespaces.Uri + ";i=49";
        /// <remarks />
        public const string Silo2Type_Silo2LevelIndicator = "nsu=" + Namespaces.Uri + ";i=63";
        /// <remarks />
        public const string Silo2Type_Silo2DischargeValve = "nsu=" + Namespaces.Uri + ";i=71";
        /// <remarks />
        public const string Silo3Type_Silo3LevelIndicator = "nsu=" + Namespaces.Uri + ";i=85";
        /// <remarks />
        public const string Silo3Type_Silo3DischargeValve = "nsu=" + Namespaces.Uri + ";i=93";
        /// <remarks />
        public const string MixerType_LoadcellTransmitter = "nsu=" + Namespaces.Uri + ";i=107";
        /// <remarks />
        public const string MixerType_MixerMotor = "nsu=" + Namespaces.Uri + ";i=121";
        /// <remarks />
        public const string MixerType_MixerDischargeValve = "nsu=" + Namespaces.Uri + ";i=128";
        /// <remarks />
        public const string PackagingUnitType_PackagingUnitLevelIndicator = "nsu=" + Namespaces.Uri + ";i=142";
        /// <remarks />
        public const string ConveyorType_ConveyorMotor = "nsu=" + Namespaces.Uri + ";i=151";
        /// <remarks />
        public const string ConveyorType_RadeKoncarMotor = "nsu=" + Namespaces.Uri + ";i=417";
        /// <remarks />
        public const string BatchPlantType_Silo1 = "nsu=" + Namespaces.Uri + ";i=159";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1LevelIndicator = "nsu=" + Namespaces.Uri + ";i=160";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1DischargeValve = "nsu=" + Namespaces.Uri + ";i=168";
        /// <remarks />
        public const string BatchPlantType_Silo1_DischargeValve = "nsu=" + Namespaces.Uri + ";i=181";
        /// <remarks />
        public const string BatchPlantType_Silo2 = "nsu=" + Namespaces.Uri + ";i=183";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2LevelIndicator = "nsu=" + Namespaces.Uri + ";i=184";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2DischargeValve = "nsu=" + Namespaces.Uri + ";i=192";
        /// <remarks />
        public const string BatchPlantType_Silo2_DischargeValve = "nsu=" + Namespaces.Uri + ";i=205";
        /// <remarks />
        public const string BatchPlantType_Silo3 = "nsu=" + Namespaces.Uri + ";i=207";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3LevelIndicator = "nsu=" + Namespaces.Uri + ";i=208";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3DischargeValve = "nsu=" + Namespaces.Uri + ";i=216";
        /// <remarks />
        public const string BatchPlantType_Silo3_DischargeValve = "nsu=" + Namespaces.Uri + ";i=229";
        /// <remarks />
        public const string BatchPlantType_Mixer = "nsu=" + Namespaces.Uri + ";i=231";
        /// <remarks />
        public const string BatchPlantType_Mixer_LoadcellTransmitter = "nsu=" + Namespaces.Uri + ";i=232";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerMotor = "nsu=" + Namespaces.Uri + ";i=246";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerDischargeValve = "nsu=" + Namespaces.Uri + ";i=253";
        /// <remarks />
        public const string BatchPlantType_Mixer_DischargeValve = "nsu=" + Namespaces.Uri + ";i=266";
        /// <remarks />
        public const string BatchPlantType_PackagingUnit = "nsu=" + Namespaces.Uri + ";i=268";
        /// <remarks />
        public const string BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = "nsu=" + Namespaces.Uri + ";i=269";
        /// <remarks />
        public const string BatchPlantType_Conveyor = "nsu=" + Namespaces.Uri + ";i=277";
        /// <remarks />
        public const string BatchPlantType_Conveyor_ConveyorMotor = "nsu=" + Namespaces.Uri + ";i=278";
        /// <remarks />
        public const string BatchPlantType_Conveyor_RadeKoncarMotor = "nsu=" + Namespaces.Uri + ";i=424";
        /// <remarks />
        public const string BatchPlant1 = "nsu=" + Namespaces.Uri + ";i=287";
        /// <remarks />
        public const string BatchPlant1_Silo1 = "nsu=" + Namespaces.Uri + ";i=288";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1LevelIndicator = "nsu=" + Namespaces.Uri + ";i=289";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1DischargeValve = "nsu=" + Namespaces.Uri + ";i=297";
        /// <remarks />
        public const string BatchPlant1_Silo1_DischargeValve = "nsu=" + Namespaces.Uri + ";i=310";
        /// <remarks />
        public const string BatchPlant1_Silo2 = "nsu=" + Namespaces.Uri + ";i=312";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2LevelIndicator = "nsu=" + Namespaces.Uri + ";i=313";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2DischargeValve = "nsu=" + Namespaces.Uri + ";i=321";
        /// <remarks />
        public const string BatchPlant1_Silo2_DischargeValve = "nsu=" + Namespaces.Uri + ";i=334";
        /// <remarks />
        public const string BatchPlant1_Silo3 = "nsu=" + Namespaces.Uri + ";i=336";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3LevelIndicator = "nsu=" + Namespaces.Uri + ";i=337";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3DischargeValve = "nsu=" + Namespaces.Uri + ";i=345";
        /// <remarks />
        public const string BatchPlant1_Silo3_DischargeValve = "nsu=" + Namespaces.Uri + ";i=358";
        /// <remarks />
        public const string BatchPlant1_Mixer = "nsu=" + Namespaces.Uri + ";i=360";
        /// <remarks />
        public const string BatchPlant1_Mixer_LoadcellTransmitter = "nsu=" + Namespaces.Uri + ";i=361";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerMotor = "nsu=" + Namespaces.Uri + ";i=375";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerDischargeValve = "nsu=" + Namespaces.Uri + ";i=382";
        /// <remarks />
        public const string BatchPlant1_Mixer_DischargeValve = "nsu=" + Namespaces.Uri + ";i=395";
        /// <remarks />
        public const string BatchPlant1_PackagingUnit = "nsu=" + Namespaces.Uri + ";i=397";
        /// <remarks />
        public const string BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = "nsu=" + Namespaces.Uri + ";i=398";
        /// <remarks />
        public const string BatchPlant1_Conveyor = "nsu=" + Namespaces.Uri + ";i=406";
        /// <remarks />
        public const string BatchPlant1_Conveyor_ConveyorMotor = "nsu=" + Namespaces.Uri + ";i=407";
        /// <remarks />
        public const string BatchPlant1_Conveyor_RadeKoncarMotor = "nsu=" + Namespaces.Uri + ";i=431";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for ObjectType nodes.
    /// </summary>
    public static class ObjectTypeIds {
        /// <remarks />
        public const string GenericSensorType = "nsu=" + Namespaces.Uri + ";i=1";
        /// <remarks />
        public const string GenericActuatorType = "nsu=" + Namespaces.Uri + ";i=9";
        /// <remarks />
        public const string GenericMotorType = "nsu=" + Namespaces.Uri + ";i=22";
        /// <remarks />
        public const string LevelIndicatorType = "nsu=" + Namespaces.Uri + ";i=29";
        /// <remarks />
        public const string LoadcellTransmitterType = "nsu=" + Namespaces.Uri + ";i=30";
        /// <remarks />
        public const string ValveType = "nsu=" + Namespaces.Uri + ";i=37";
        /// <remarks />
        public const string MixerMotorType = "nsu=" + Namespaces.Uri + ";i=38";
        /// <remarks />
        public const string ConveyorMotorType = "nsu=" + Namespaces.Uri + ";i=39";
        /// <remarks />
        public const string RadeKoncarMotorType = "nsu=" + Namespaces.Uri + ";i=416";
        /// <remarks />
        public const string Silo1Type = "nsu=" + Namespaces.Uri + ";i=40";
        /// <remarks />
        public const string Silo2Type = "nsu=" + Namespaces.Uri + ";i=62";
        /// <remarks />
        public const string Silo3Type = "nsu=" + Namespaces.Uri + ";i=84";
        /// <remarks />
        public const string MixerType = "nsu=" + Namespaces.Uri + ";i=106";
        /// <remarks />
        public const string PackagingUnitType = "nsu=" + Namespaces.Uri + ";i=141";
        /// <remarks />
        public const string ConveyorType = "nsu=" + Namespaces.Uri + ";i=150";
        /// <remarks />
        public const string BatchPlantType = "nsu=" + Namespaces.Uri + ";i=158";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(ObjectTypeIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }

    /// <summary>
    /// The well known identifiers for Variable nodes.
    /// </summary>
    public static class VariableIds {
        /// <remarks />
        public const string GenericSensorType_Output = "nsu=" + Namespaces.Uri + ";i=2";
        /// <remarks />
        public const string GenericSensorType_Output_EURange = "nsu=" + Namespaces.Uri + ";i=6";
        /// <remarks />
        public const string GenericSensorType_Units = "nsu=" + Namespaces.Uri + ";i=8";
        /// <remarks />
        public const string GenericActuatorType_Input = "nsu=" + Namespaces.Uri + ";i=10";
        /// <remarks />
        public const string GenericActuatorType_Input_EURange = "nsu=" + Namespaces.Uri + ";i=14";
        /// <remarks />
        public const string GenericActuatorType_Output = "nsu=" + Namespaces.Uri + ";i=16";
        /// <remarks />
        public const string GenericActuatorType_Output_EURange = "nsu=" + Namespaces.Uri + ";i=20";
        /// <remarks />
        public const string GenericMotorType_Speed = "nsu=" + Namespaces.Uri + ";i=23";
        /// <remarks />
        public const string GenericMotorType_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=27";
        /// <remarks />
        public const string LoadcellTransmitterType_ExcitationVoltage = "nsu=" + Namespaces.Uri + ";i=31";
        /// <remarks />
        public const string LoadcellTransmitterType_ExcitationVoltage_EURange = "nsu=" + Namespaces.Uri + ";i=35";
        /// <remarks />
        public const string Silo1Type_Silo1LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=42";
        /// <remarks />
        public const string Silo1Type_Silo1LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=46";
        /// <remarks />
        public const string Silo1Type_Silo1LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=48";
        /// <remarks />
        public const string Silo1Type_Silo1DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=50";
        /// <remarks />
        public const string Silo1Type_Silo1DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=54";
        /// <remarks />
        public const string Silo1Type_Silo1DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=56";
        /// <remarks />
        public const string Silo1Type_Silo1DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=60";
        /// <remarks />
        public const string Silo2Type_Silo2LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=64";
        /// <remarks />
        public const string Silo2Type_Silo2LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=68";
        /// <remarks />
        public const string Silo2Type_Silo2LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=70";
        /// <remarks />
        public const string Silo2Type_Silo2DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=72";
        /// <remarks />
        public const string Silo2Type_Silo2DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=76";
        /// <remarks />
        public const string Silo2Type_Silo2DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=78";
        /// <remarks />
        public const string Silo2Type_Silo2DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=82";
        /// <remarks />
        public const string Silo3Type_Silo3LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=86";
        /// <remarks />
        public const string Silo3Type_Silo3LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=90";
        /// <remarks />
        public const string Silo3Type_Silo3LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=92";
        /// <remarks />
        public const string Silo3Type_Silo3DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=94";
        /// <remarks />
        public const string Silo3Type_Silo3DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=98";
        /// <remarks />
        public const string Silo3Type_Silo3DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=100";
        /// <remarks />
        public const string Silo3Type_Silo3DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=104";
        /// <remarks />
        public const string MixerType_LoadcellTransmitter_Output = "nsu=" + Namespaces.Uri + ";i=108";
        /// <remarks />
        public const string MixerType_LoadcellTransmitter_Output_EURange = "nsu=" + Namespaces.Uri + ";i=112";
        /// <remarks />
        public const string MixerType_LoadcellTransmitter_Units = "nsu=" + Namespaces.Uri + ";i=114";
        /// <remarks />
        public const string MixerType_LoadcellTransmitter_ExcitationVoltage = "nsu=" + Namespaces.Uri + ";i=115";
        /// <remarks />
        public const string MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = "nsu=" + Namespaces.Uri + ";i=119";
        /// <remarks />
        public const string MixerType_MixerMotor_Speed = "nsu=" + Namespaces.Uri + ";i=122";
        /// <remarks />
        public const string MixerType_MixerMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=126";
        /// <remarks />
        public const string MixerType_MixerDischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=129";
        /// <remarks />
        public const string MixerType_MixerDischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=133";
        /// <remarks />
        public const string MixerType_MixerDischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=135";
        /// <remarks />
        public const string MixerType_MixerDischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=139";
        /// <remarks />
        public const string PackagingUnitType_PackagingUnitLevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=143";
        /// <remarks />
        public const string PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=147";
        /// <remarks />
        public const string PackagingUnitType_PackagingUnitLevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=149";
        /// <remarks />
        public const string ConveyorType_ConveyorMotor_Speed = "nsu=" + Namespaces.Uri + ";i=152";
        /// <remarks />
        public const string ConveyorType_ConveyorMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=156";
        /// <remarks />
        public const string ConveyorType_RadeKoncarMotor_Speed = "nsu=" + Namespaces.Uri + ";i=418";
        /// <remarks />
        public const string ConveyorType_RadeKoncarMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=422";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=161";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=165";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=167";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=169";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=173";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=175";
        /// <remarks />
        public const string BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=179";
        /// <remarks />
        public const string BatchPlantType_Silo1_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=182";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=185";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=189";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=191";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=193";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=197";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=199";
        /// <remarks />
        public const string BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=203";
        /// <remarks />
        public const string BatchPlantType_Silo2_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=206";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=209";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=213";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=215";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=217";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=221";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=223";
        /// <remarks />
        public const string BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=227";
        /// <remarks />
        public const string BatchPlantType_Silo3_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=230";
        /// <remarks />
        public const string BatchPlantType_Mixer_LoadcellTransmitter_Output = "nsu=" + Namespaces.Uri + ";i=233";
        /// <remarks />
        public const string BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = "nsu=" + Namespaces.Uri + ";i=237";
        /// <remarks />
        public const string BatchPlantType_Mixer_LoadcellTransmitter_Units = "nsu=" + Namespaces.Uri + ";i=239";
        /// <remarks />
        public const string BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = "nsu=" + Namespaces.Uri + ";i=240";
        /// <remarks />
        public const string BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = "nsu=" + Namespaces.Uri + ";i=244";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerMotor_Speed = "nsu=" + Namespaces.Uri + ";i=247";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=251";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerDischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=254";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=258";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerDischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=260";
        /// <remarks />
        public const string BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=264";
        /// <remarks />
        public const string BatchPlantType_Mixer_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=267";
        /// <remarks />
        public const string BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=270";
        /// <remarks />
        public const string BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=274";
        /// <remarks />
        public const string BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=276";
        /// <remarks />
        public const string BatchPlantType_Conveyor_ConveyorMotor_Speed = "nsu=" + Namespaces.Uri + ";i=279";
        /// <remarks />
        public const string BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=283";
        /// <remarks />
        public const string BatchPlantType_Conveyor_RadeKoncarMotor_Speed = "nsu=" + Namespaces.Uri + ";i=425";
        /// <remarks />
        public const string BatchPlantType_Conveyor_RadeKoncarMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=429";
        /// <remarks />
        public const string BatchPlantType_Conveyor_RadeKoncarMotor_Spood = "nsu=" + Namespaces.Uri + ";i=438";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=290";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=294";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=296";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=298";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=302";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=304";
        /// <remarks />
        public const string BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=308";
        /// <remarks />
        public const string BatchPlant1_Silo1_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=311";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=314";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=318";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=320";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=322";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=326";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=328";
        /// <remarks />
        public const string BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=332";
        /// <remarks />
        public const string BatchPlant1_Silo2_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=335";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3LevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=338";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=342";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3LevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=344";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=346";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=350";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3DischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=352";
        /// <remarks />
        public const string BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=356";
        /// <remarks />
        public const string BatchPlant1_Silo3_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=359";
        /// <remarks />
        public const string BatchPlant1_Mixer_LoadcellTransmitter_Output = "nsu=" + Namespaces.Uri + ";i=362";
        /// <remarks />
        public const string BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = "nsu=" + Namespaces.Uri + ";i=366";
        /// <remarks />
        public const string BatchPlant1_Mixer_LoadcellTransmitter_Units = "nsu=" + Namespaces.Uri + ";i=368";
        /// <remarks />
        public const string BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = "nsu=" + Namespaces.Uri + ";i=369";
        /// <remarks />
        public const string BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = "nsu=" + Namespaces.Uri + ";i=373";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerMotor_Speed = "nsu=" + Namespaces.Uri + ";i=376";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=380";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerDischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=383";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = "nsu=" + Namespaces.Uri + ";i=387";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerDischargeValve_Output = "nsu=" + Namespaces.Uri + ";i=389";
        /// <remarks />
        public const string BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = "nsu=" + Namespaces.Uri + ";i=393";
        /// <remarks />
        public const string BatchPlant1_Mixer_DischargeValve_Input = "nsu=" + Namespaces.Uri + ";i=396";
        /// <remarks />
        public const string BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = "nsu=" + Namespaces.Uri + ";i=399";
        /// <remarks />
        public const string BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = "nsu=" + Namespaces.Uri + ";i=403";
        /// <remarks />
        public const string BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = "nsu=" + Namespaces.Uri + ";i=405";
        /// <remarks />
        public const string BatchPlant1_Conveyor_ConveyorMotor_Speed = "nsu=" + Namespaces.Uri + ";i=408";
        /// <remarks />
        public const string BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=412";
        /// <remarks />
        public const string BatchPlant1_Conveyor_RadeKoncarMotor_Speed = "nsu=" + Namespaces.Uri + ";i=432";
        /// <remarks />
        public const string BatchPlant1_Conveyor_RadeKoncarMotor_Speed_EURange = "nsu=" + Namespaces.Uri + ";i=436";
        /// <remarks />
        public const string BatchPlant1_Conveyor_RadeKoncarMotor_Spood = "nsu=" + Namespaces.Uri + ";i=439";

        /// <summary>
        /// Converts a value to a name for display.
        /// </summary>
        public static string ToName(string value)
        {
            foreach (var field in typeof(VariableIds).GetFields(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
            {
                if (field.GetValue(null).Equals(value))
                {
                    return field.Name;
                }
            }

            return value.ToString();
        }
    }
    
}