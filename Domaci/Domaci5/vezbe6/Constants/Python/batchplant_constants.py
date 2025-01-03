from enum import Enum

class Namespaces(Enum):
     Uri = "http://opcfoundation.org/BatchPlant"

class BrowseNames(Enum):
    BatchPlant1 = "Batch Plant #1"
    BatchPlantType = "BatchPlantType"
    Conveyor = "ConveyorX001"
    ConveyorMotor = "Motor02"
    ConveyorMotorType = "ConveyorMotorType"
    ConveyorType = "ConveyorType"
    ExcitationVoltage = "ExcitationVoltage"
    GenericActuatorType = "GenericActuatorType"
    GenericMotorType = "GenericMotorType"
    GenericSensorType = "GenericSensorType"
    Input = "Input"
    LevelIndicatorType = "LevelIndicatorType"
    LoadcellTransmitter = "LT001"
    LoadcellTransmitterType = "LoadcellTransmitterType"
    Mixer = "MixerX001"
    MixerDischargeValve = "Valve004"
    MixerMotor = "Motor01"
    MixerMotorType = "MixerMotorType"
    MixerType = "MixerType"
    Output = "Output"
    PackagingUnit = "PackagingUnitX001"
    PackagingUnitLevelIndicator = "LI004"
    PackagingUnitType = "PackagingUnitType"
    RadeKoncarMotor = "Motor03"
    RadeKoncarMotorType = "RadeKoncarMotorType"
    Silo1 = "SiloX001"
    Silo1DischargeValve = "Valve001"
    Silo1LevelIndicator = "LI001"
    Silo1Type = "Silo1Type"
    Silo2 = "SiloX002"
    Silo2DischargeValve = "Valve002"
    Silo2LevelIndicator = "LI002"
    Silo2Type = "Silo2Type"
    Silo3 = "SiloX003"
    Silo3DischargeValve = "Valve003"
    Silo3LevelIndicator = "LI003"
    Silo3Type = "Silo3Type"
    Speed = "Speed"
    StartProcess = "StartProcess"
    StopProcess = "StopProcess"
    Units = "Units"
    ValveType = "ValveType"

class MethodIds(Enum):
    BatchPlantType_StartProcess = "nsu=http://opcfoundation.org/BatchPlant;i=285"
    BatchPlantType_StopProcess = "nsu=http://opcfoundation.org/BatchPlant;i=286"
    BatchPlant1_StartProcess = "nsu=http://opcfoundation.org/BatchPlant;i=414"
    BatchPlant1_StopProcess = "nsu=http://opcfoundation.org/BatchPlant;i=415"

def get_MethodIds_name(value: str) -> str:
    try:
        return MethodIds(value).name
    except ValueError:
        return None


class ObjectIds(Enum):
    Silo1Type_Silo1LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=41"
    Silo1Type_Silo1DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=49"
    Silo2Type_Silo2LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=63"
    Silo2Type_Silo2DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=71"
    Silo3Type_Silo3LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=85"
    Silo3Type_Silo3DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=93"
    MixerType_LoadcellTransmitter = "nsu=http://opcfoundation.org/BatchPlant;i=107"
    MixerType_MixerMotor = "nsu=http://opcfoundation.org/BatchPlant;i=121"
    MixerType_MixerDischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=128"
    PackagingUnitType_PackagingUnitLevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=142"
    ConveyorType_ConveyorMotor = "nsu=http://opcfoundation.org/BatchPlant;i=151"
    ConveyorType_RadeKoncarMotor = "nsu=http://opcfoundation.org/BatchPlant;i=417"
    BatchPlantType_Silo1 = "nsu=http://opcfoundation.org/BatchPlant;i=159"
    BatchPlantType_Silo1_Silo1LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=160"
    BatchPlantType_Silo1_Silo1DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=168"
    BatchPlantType_Silo1_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=181"
    BatchPlantType_Silo2 = "nsu=http://opcfoundation.org/BatchPlant;i=183"
    BatchPlantType_Silo2_Silo2LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=184"
    BatchPlantType_Silo2_Silo2DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=192"
    BatchPlantType_Silo2_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=205"
    BatchPlantType_Silo3 = "nsu=http://opcfoundation.org/BatchPlant;i=207"
    BatchPlantType_Silo3_Silo3LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=208"
    BatchPlantType_Silo3_Silo3DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=216"
    BatchPlantType_Silo3_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=229"
    BatchPlantType_Mixer = "nsu=http://opcfoundation.org/BatchPlant;i=231"
    BatchPlantType_Mixer_LoadcellTransmitter = "nsu=http://opcfoundation.org/BatchPlant;i=232"
    BatchPlantType_Mixer_MixerMotor = "nsu=http://opcfoundation.org/BatchPlant;i=246"
    BatchPlantType_Mixer_MixerDischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=253"
    BatchPlantType_Mixer_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=266"
    BatchPlantType_PackagingUnit = "nsu=http://opcfoundation.org/BatchPlant;i=268"
    BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=269"
    BatchPlantType_Conveyor = "nsu=http://opcfoundation.org/BatchPlant;i=277"
    BatchPlantType_Conveyor_ConveyorMotor = "nsu=http://opcfoundation.org/BatchPlant;i=278"
    BatchPlantType_Conveyor_RadeKoncarMotor = "nsu=http://opcfoundation.org/BatchPlant;i=424"
    BatchPlant1 = "nsu=http://opcfoundation.org/BatchPlant;i=287"
    BatchPlant1_Silo1 = "nsu=http://opcfoundation.org/BatchPlant;i=288"
    BatchPlant1_Silo1_Silo1LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=289"
    BatchPlant1_Silo1_Silo1DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=297"
    BatchPlant1_Silo1_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=310"
    BatchPlant1_Silo2 = "nsu=http://opcfoundation.org/BatchPlant;i=312"
    BatchPlant1_Silo2_Silo2LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=313"
    BatchPlant1_Silo2_Silo2DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=321"
    BatchPlant1_Silo2_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=334"
    BatchPlant1_Silo3 = "nsu=http://opcfoundation.org/BatchPlant;i=336"
    BatchPlant1_Silo3_Silo3LevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=337"
    BatchPlant1_Silo3_Silo3DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=345"
    BatchPlant1_Silo3_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=358"
    BatchPlant1_Mixer = "nsu=http://opcfoundation.org/BatchPlant;i=360"
    BatchPlant1_Mixer_LoadcellTransmitter = "nsu=http://opcfoundation.org/BatchPlant;i=361"
    BatchPlant1_Mixer_MixerMotor = "nsu=http://opcfoundation.org/BatchPlant;i=375"
    BatchPlant1_Mixer_MixerDischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=382"
    BatchPlant1_Mixer_DischargeValve = "nsu=http://opcfoundation.org/BatchPlant;i=395"
    BatchPlant1_PackagingUnit = "nsu=http://opcfoundation.org/BatchPlant;i=397"
    BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = "nsu=http://opcfoundation.org/BatchPlant;i=398"
    BatchPlant1_Conveyor = "nsu=http://opcfoundation.org/BatchPlant;i=406"
    BatchPlant1_Conveyor_ConveyorMotor = "nsu=http://opcfoundation.org/BatchPlant;i=407"
    BatchPlant1_Conveyor_RadeKoncarMotor = "nsu=http://opcfoundation.org/BatchPlant;i=431"

def get_ObjectIds_name(value: str) -> str:
    try:
        return ObjectIds(value).name
    except ValueError:
        return None


class ObjectTypeIds(Enum):
    GenericSensorType = "nsu=http://opcfoundation.org/BatchPlant;i=1"
    GenericActuatorType = "nsu=http://opcfoundation.org/BatchPlant;i=9"
    GenericMotorType = "nsu=http://opcfoundation.org/BatchPlant;i=22"
    LevelIndicatorType = "nsu=http://opcfoundation.org/BatchPlant;i=29"
    LoadcellTransmitterType = "nsu=http://opcfoundation.org/BatchPlant;i=30"
    ValveType = "nsu=http://opcfoundation.org/BatchPlant;i=37"
    MixerMotorType = "nsu=http://opcfoundation.org/BatchPlant;i=38"
    ConveyorMotorType = "nsu=http://opcfoundation.org/BatchPlant;i=39"
    RadeKoncarMotorType = "nsu=http://opcfoundation.org/BatchPlant;i=416"
    Silo1Type = "nsu=http://opcfoundation.org/BatchPlant;i=40"
    Silo2Type = "nsu=http://opcfoundation.org/BatchPlant;i=62"
    Silo3Type = "nsu=http://opcfoundation.org/BatchPlant;i=84"
    MixerType = "nsu=http://opcfoundation.org/BatchPlant;i=106"
    PackagingUnitType = "nsu=http://opcfoundation.org/BatchPlant;i=141"
    ConveyorType = "nsu=http://opcfoundation.org/BatchPlant;i=150"
    BatchPlantType = "nsu=http://opcfoundation.org/BatchPlant;i=158"

def get_ObjectTypeIds_name(value: str) -> str:
    try:
        return ObjectTypeIds(value).name
    except ValueError:
        return None


class VariableIds(Enum):
    GenericSensorType_Output = "nsu=http://opcfoundation.org/BatchPlant;i=2"
    GenericSensorType_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=6"
    GenericSensorType_Units = "nsu=http://opcfoundation.org/BatchPlant;i=8"
    GenericActuatorType_Input = "nsu=http://opcfoundation.org/BatchPlant;i=10"
    GenericActuatorType_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=14"
    GenericActuatorType_Output = "nsu=http://opcfoundation.org/BatchPlant;i=16"
    GenericActuatorType_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=20"
    GenericMotorType_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=23"
    GenericMotorType_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=27"
    LoadcellTransmitterType_ExcitationVoltage = "nsu=http://opcfoundation.org/BatchPlant;i=31"
    LoadcellTransmitterType_ExcitationVoltage_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=35"
    Silo1Type_Silo1LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=42"
    Silo1Type_Silo1LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=46"
    Silo1Type_Silo1LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=48"
    Silo1Type_Silo1DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=50"
    Silo1Type_Silo1DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=54"
    Silo1Type_Silo1DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=56"
    Silo1Type_Silo1DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=60"
    Silo2Type_Silo2LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=64"
    Silo2Type_Silo2LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=68"
    Silo2Type_Silo2LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=70"
    Silo2Type_Silo2DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=72"
    Silo2Type_Silo2DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=76"
    Silo2Type_Silo2DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=78"
    Silo2Type_Silo2DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=82"
    Silo3Type_Silo3LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=86"
    Silo3Type_Silo3LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=90"
    Silo3Type_Silo3LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=92"
    Silo3Type_Silo3DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=94"
    Silo3Type_Silo3DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=98"
    Silo3Type_Silo3DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=100"
    Silo3Type_Silo3DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=104"
    MixerType_LoadcellTransmitter_Output = "nsu=http://opcfoundation.org/BatchPlant;i=108"
    MixerType_LoadcellTransmitter_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=112"
    MixerType_LoadcellTransmitter_Units = "nsu=http://opcfoundation.org/BatchPlant;i=114"
    MixerType_LoadcellTransmitter_ExcitationVoltage = "nsu=http://opcfoundation.org/BatchPlant;i=115"
    MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=119"
    MixerType_MixerMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=122"
    MixerType_MixerMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=126"
    MixerType_MixerDischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=129"
    MixerType_MixerDischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=133"
    MixerType_MixerDischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=135"
    MixerType_MixerDischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=139"
    PackagingUnitType_PackagingUnitLevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=143"
    PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=147"
    PackagingUnitType_PackagingUnitLevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=149"
    ConveyorType_ConveyorMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=152"
    ConveyorType_ConveyorMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=156"
    ConveyorType_RadeKoncarMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=418"
    ConveyorType_RadeKoncarMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=422"
    BatchPlantType_Silo1_Silo1LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=161"
    BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=165"
    BatchPlantType_Silo1_Silo1LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=167"
    BatchPlantType_Silo1_Silo1DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=169"
    BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=173"
    BatchPlantType_Silo1_Silo1DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=175"
    BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=179"
    BatchPlantType_Silo1_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=182"
    BatchPlantType_Silo2_Silo2LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=185"
    BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=189"
    BatchPlantType_Silo2_Silo2LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=191"
    BatchPlantType_Silo2_Silo2DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=193"
    BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=197"
    BatchPlantType_Silo2_Silo2DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=199"
    BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=203"
    BatchPlantType_Silo2_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=206"
    BatchPlantType_Silo3_Silo3LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=209"
    BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=213"
    BatchPlantType_Silo3_Silo3LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=215"
    BatchPlantType_Silo3_Silo3DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=217"
    BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=221"
    BatchPlantType_Silo3_Silo3DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=223"
    BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=227"
    BatchPlantType_Silo3_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=230"
    BatchPlantType_Mixer_LoadcellTransmitter_Output = "nsu=http://opcfoundation.org/BatchPlant;i=233"
    BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=237"
    BatchPlantType_Mixer_LoadcellTransmitter_Units = "nsu=http://opcfoundation.org/BatchPlant;i=239"
    BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = "nsu=http://opcfoundation.org/BatchPlant;i=240"
    BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=244"
    BatchPlantType_Mixer_MixerMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=247"
    BatchPlantType_Mixer_MixerMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=251"
    BatchPlantType_Mixer_MixerDischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=254"
    BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=258"
    BatchPlantType_Mixer_MixerDischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=260"
    BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=264"
    BatchPlantType_Mixer_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=267"
    BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=270"
    BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=274"
    BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=276"
    BatchPlantType_Conveyor_ConveyorMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=279"
    BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=283"
    BatchPlantType_Conveyor_RadeKoncarMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=425"
    BatchPlantType_Conveyor_RadeKoncarMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=429"
    BatchPlantType_Conveyor_RadeKoncarMotor_Spood = "nsu=http://opcfoundation.org/BatchPlant;i=438"
    BatchPlant1_Silo1_Silo1LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=290"
    BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=294"
    BatchPlant1_Silo1_Silo1LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=296"
    BatchPlant1_Silo1_Silo1DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=298"
    BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=302"
    BatchPlant1_Silo1_Silo1DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=304"
    BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=308"
    BatchPlant1_Silo1_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=311"
    BatchPlant1_Silo2_Silo2LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=314"
    BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=318"
    BatchPlant1_Silo2_Silo2LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=320"
    BatchPlant1_Silo2_Silo2DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=322"
    BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=326"
    BatchPlant1_Silo2_Silo2DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=328"
    BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=332"
    BatchPlant1_Silo2_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=335"
    BatchPlant1_Silo3_Silo3LevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=338"
    BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=342"
    BatchPlant1_Silo3_Silo3LevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=344"
    BatchPlant1_Silo3_Silo3DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=346"
    BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=350"
    BatchPlant1_Silo3_Silo3DischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=352"
    BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=356"
    BatchPlant1_Silo3_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=359"
    BatchPlant1_Mixer_LoadcellTransmitter_Output = "nsu=http://opcfoundation.org/BatchPlant;i=362"
    BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=366"
    BatchPlant1_Mixer_LoadcellTransmitter_Units = "nsu=http://opcfoundation.org/BatchPlant;i=368"
    BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = "nsu=http://opcfoundation.org/BatchPlant;i=369"
    BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=373"
    BatchPlant1_Mixer_MixerMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=376"
    BatchPlant1_Mixer_MixerMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=380"
    BatchPlant1_Mixer_MixerDischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=383"
    BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=387"
    BatchPlant1_Mixer_MixerDischargeValve_Output = "nsu=http://opcfoundation.org/BatchPlant;i=389"
    BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=393"
    BatchPlant1_Mixer_DischargeValve_Input = "nsu=http://opcfoundation.org/BatchPlant;i=396"
    BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = "nsu=http://opcfoundation.org/BatchPlant;i=399"
    BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=403"
    BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = "nsu=http://opcfoundation.org/BatchPlant;i=405"
    BatchPlant1_Conveyor_ConveyorMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=408"
    BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=412"
    BatchPlant1_Conveyor_RadeKoncarMotor_Speed = "nsu=http://opcfoundation.org/BatchPlant;i=432"
    BatchPlant1_Conveyor_RadeKoncarMotor_Speed_EURange = "nsu=http://opcfoundation.org/BatchPlant;i=436"
    BatchPlant1_Conveyor_RadeKoncarMotor_Spood = "nsu=http://opcfoundation.org/BatchPlant;i=439"

def get_VariableIds_name(value: str) -> str:
    try:
        return VariableIds(value).name
    except ValueError:
        return None

