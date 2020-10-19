using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionApp.viperDevice
{
    class DataStatic
    {
        public const int DATATYPE = 0;

        #region ****** ViperData Static tag ******
        public const String tag_DataType       = "DataType";
        public const String tag_Customer       = "Customer";
        public const String tag_ViperID        = "ViperID";
        public const String tag_MsgTimestamp   = "MsgTimestamp";

        // static
        public const String tag_ProductName    = "ProductName";
        public const String tag_MachineName    = "MachineName";
        public const String tag_CompanyName    = "CompanyName";
        public const String tag_OS             = "OS";
        public const String tag_BIOS           = "BIOS";
        public const String tag_MB             = "MB";
        public const String tag_Memory         = "Memory";
        
        // static is information AND dynamic is state
        public const String tag_CPU            = "CPU";
        public const String tag_Storage        = "Storage";
        public const String tag_Network        = "Network";
        public const String tag_Graphics       = "Graphics";
        public const String tag_Peripheral     = "Peripheral";

        // ====================== Sub Tag ======================
        // OS tag
        public const String tagOS_Name             = "Name";
        public const String tagOS_Edition          = "Edition";
        public const String tagOS_Version          = "Version";
        public const String tagOS_Build            = "Build";

        // BIOS tag
        public const String tagBios_Manufacturer             = "Manufacturer";
        public const String tagBios_Version                  = "Version";

        // MotherBoard tag
        public const String tagMB_Manufacturer             = "Manufacturer";
        public const String tagMB_Model                    = "Model";
        public const String tagMB_MemoryModuleSlots        = "MemoryModuleSlots";
        public const String tagMB_TotalMemoryCapacity      = "TotalMemoryCapacity";
        public const String tagMB_amount                   = "amount";
        public const String tagMB_unit                     = "unit";
        public const String tagMB_SN                       = "SN";
        public const String tagMB_MCUVersion               = "MCUVersion";
        public const String tagMB_ECVersion                = "ECVersion";
        public const String tagMB_PanelID                  = "PanelID";

        // CPU tag
        public const String tagCPU_Manufacturer             = "Manufacturer";
        public const String tagCPU_Model                    = "Model";
        public const String tagCPU_Speed                    = "Speed";
        public const String tagCPU_PhysicalCores            = "PhysicalCores";
        public const String tagCPU_VirtualCores             = "VirtualCores";
        public const String tagCPU_SN                       = "SN";
        public const String tagCPU_OperatingTemperature     = "OperatingTemperature";
        public const String tagCPU_amount                   = "amount";
        public const String tagCPU_unit                     = "unit";

        // Memory tag
        public const String tagMem_QuantityofModules        = "QuantityofModules";
        public const String tagMem_TotalMemory              = "TotalMemory";
        public const String tagMem_amount                   = "amount";
        public const String tagMem_unit                     = "unit";
        public const String tagMem_RAM                      = "RAM";
        // ========================================================================
        #endregion

        #region ****** PROPERTIES ******
        // static data
        public Object dataType;
        public Object viperId;
        public Object msgTimestamp;
        public Object customer;
        public Object productName;
        public Object machineName;
        public Object companyName;

        // OS Properties
        public Object osName;
        public Object osEdition;
        public Object osVersion;
        public Object osBuild;

        // BIOS Properties
        public Object biosManufacture;
        public Object biosVersion;

        // MB Properties
        public Object mbManufacture;
        public Object mbModel;
        public Object mbMemoryModuleSlots;
        public Object mbMemoryCapacity;
        public Object mbMemoryUnit;
        public Object mbSN;
        public Object mbMCUVersion;
        public Object mbECVersion;
        public Object mbPanelId;

        // CPU Properties
        public Object cpuManufacture;
        public Object cpuModel;
        public Object cpuSpeed;
        public Object cpuPyhsicalCores;
        public Object cpuVirtualCores;
        public Object cpuSN;

        // Memory Properties
        public Object memoryQuantity;
        public Object memoryAmount;
        public Object memoryUnit;
        #endregion
        //    public List<> lst_memoryRam;

        //    public lst_storage = array();
        //    public lst_network = array();
        //    public lst_graphic = array();
        //    public lst_peripheral = array();
        //    #endregion

        //    public function __construct($viperData)
        //    {
        //        $this->parsingData($viperData);
        //    }

        //    // <editor-fold desc='****** PRIVATE FUNCTION ******
        //    private function parsingData($viperData)
        //    {
        //        if ($viperData){
        //        $this->dataType = self::validateKey( $viperData, self::tag_DataType);
        //        $this->viperId = self::validateKey( $viperData, self::tag_ViperID);
        //        $this->msgTimestamp = self::validateKey( $viperData, self::tag_MsgTimestamp);
        //        $this->customer = self::validateKey( $viperData, self::tag_Customer);
        //        $this->productName = self::validateKey( $viperData, self::tag_ProductName);
        //        $this->machineName = self::validateKey( $viperData, self::tag_MachineName);
        //        $this->companyName = self::validateKey( $viperData, self::tag_CompanyName);

        //        $os = self::validateKey( $viperData, self::tag_OS);
        //           #region ****** OS ******'>
        //            if ($os){
        //            $this->osName = self::validateKey( $os, self::tagOS_Name);
        //            $this->osEdition = self::validateKey( $os, self::tagOS_Edition);
        //            $this->osVersion = self::validateKey( $os, self::tagOS_Version);
        //            $this->osBuild = self::validateKey( $os, self::tagOS_Build);
        //            }
        //        // </editor-fold>

        //        $bios = self::validateKey( $viperData, self::tag_BIOS);
        //           #region ****** BIOS ******
        //            if ($bios){
        //            $this->biosManufacture = self::validateKey( $bios, self::tagBios_Manufacturer);
        //            $this->biosVersion = self::validateKey( $bios, self::tagBios_Version);
        //            }
        //        // </editor-fold>

        //        $motherBoard = self::validateKey( $viperData, self::tag_MB);
        //           #region ****** MotherBoard ******
        //            if ($motherBoard){
        //            $this->mbManufacture = self::validateKey( $motherBoard, self::tagMB_Manufacturer);
        //            $this->mbModel = self::validateKey( $motherBoard, self::tagMB_Model);
        //            $this->mbMemoryModuleSlots = self::validateKey( $motherBoard, self::tagMB_MemoryModuleSlots);
        //            $this->mbSN = self::validateKey( $motherBoard, self::tagMB_SN);
        //            $this->mbMCUVersion = self::validateKey( $motherBoard, self::tagMB_MCUVersion);
        //            $this->mbECVersion = self::validateKey( $motherBoard, self::tagMB_ECVersion);
        //            $this->mbPanelId = self::validateKey( $motherBoard, self::tagMB_PanelID);
        //            $TotalMemoryCapacity = self::validateKey( $motherBoard, self::tagMB_TotalMemoryCapacity);
        //                if ($TotalMemoryCapacity){
        //                $this->mbMemoryCapacity = self::validateKey( $TotalMemoryCapacity, self::tagMB_amount);
        //                $this->mbMemoryUnit = self::validateKey( $TotalMemoryCapacity, self::tagMB_unit);
        //                }
        //            }
        //        // </editor-fold>

        //        $cpu = self::validateKey( $viperData, self::tag_CPU);
        //           #region ****** MotherBoard ******
        //            if ($cpu){
        //            $this->cpuManufacture = self::validateKey( $cpu, self::tagCPU_Manufacturer);
        //            $this->cpuModel = self::validateKey( $cpu, self::tagCPU_Model);
        //            $this->cpuSpeed = self::validateKey( $cpu, self::tagCPU_Speed);
        //            $this->cpuPyhsicalCores = self::validateKey( $cpu, self::tagCPU_PhysicalCores);
        //            $this->cpuVirtualCores = self::validateKey( $cpu, self::tagCPU_VirtualCores);
        //            $this->cpuSN = self::validateKey( $cpu, self::tagCPU_SN);
        //            }
        //        // </editor-fold>

        //        $memory = self::validateKey( $viperData, self::tag_Memory);
        //           #region ****** MotherBoard ******
        //            if ($memory){
        //            $this->memoryQuantity = self::validateKey( $memory, self::tagMem_QuantityofModules);
        //            $totalMemory = self::validateKey( $memory, self::tagMem_TotalMemory);
        //                if ($totalMemory){
        //                $this->memoryAmount = self::validateKey( $totalMemory, self::tagMem_amount);
        //                $this->memoryUnit = self::validateKey( $totalMemory, self::tagMem_unit);
        //                }
        //            $arrRam = self::validateKey( $memory, self::tagMem_RAM);
        //                if ($arrRam){
        //                    foreach ($arrRam as $key => $value){
        //                    $obj = new RamStatic($value);
        //                        array_push($this->lst_memoryRam, $obj);
        //                    }
        //                }
        //            }
        //        // </editor-fold>

        //       #region ****** STATIC Storage, Network, Graphic, Peripheral ******
        //        $arrStorage = self::validateKey( $viperData, self::tag_Storage);
        //            if ($arrStorage){
        //                foreach ($arrStorage as $key => $value){
        //                $obj = new StorageStatic($value);
        //                    array_push($this->lst_storage, $obj);
        //                }
        //            }

        //        $arrNetwork = self::validateKey( $viperData, self::tag_Network);
        //            if ($arrNetwork){
        //                foreach ($arrNetwork as $key => $value){
        //                $obj = new NetworkStatic($value);
        //                    array_push($this->lst_network, $obj);
        //                }
        //            }

        //        $arrGraphic = self::validateKey( $viperData, self::tag_Graphics);
        //            if ($arrGraphic){
        //                foreach ($arrGraphic as $key => $value) {
        //                $obj = new GraphicStatic($value);
        //                    array_push($this->lst_graphic, $obj);
        //                }
        //            }

        //        $arrPeripheral = self::validateKey( $viperData, self::tag_Peripheral);
        //            if ($arrPeripheral){
        //                foreach ($arrPeripheral as $key => $value) {
        //                $obj = new PeripheralStatic($value);
        //                    array_push($this->lst_peripheral, $obj);
        //                }
        //            }
        //            // </editor-fold>

        //        }  // end viperData
        //    }
        //    // </editor-fold>
    }
}
