#pragma warning disable 1717
namespace Android
{
		/// <java-name>
		/// android/Manifest
		/// </java-name>
		[Dot42.DexImport("android/Manifest", AccessFlags = 49)]
		public sealed partial class Manifest
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public Manifest() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/Manifest$permission_group
				/// </java-name>
				[Dot42.DexImport("android/Manifest$permission_group", AccessFlags = 25)]
				public sealed partial class Permission_group
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ACCOUNTS
						/// </java-name>
						[Dot42.DexImport("ACCOUNTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNTS = "android.permission-group.ACCOUNTS";
						/// <java-name>
						/// COST_MONEY
						/// </java-name>
						[Dot42.DexImport("COST_MONEY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string COST_MONEY = "android.permission-group.COST_MONEY";
						/// <java-name>
						/// DEVELOPMENT_TOOLS
						/// </java-name>
						[Dot42.DexImport("DEVELOPMENT_TOOLS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEVELOPMENT_TOOLS = "android.permission-group.DEVELOPMENT_TOOLS";
						/// <java-name>
						/// HARDWARE_CONTROLS
						/// </java-name>
						[Dot42.DexImport("HARDWARE_CONTROLS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HARDWARE_CONTROLS = "android.permission-group.HARDWARE_CONTROLS";
						/// <java-name>
						/// LOCATION
						/// </java-name>
						[Dot42.DexImport("LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string LOCATION = "android.permission-group.LOCATION";
						/// <java-name>
						/// MESSAGES
						/// </java-name>
						[Dot42.DexImport("MESSAGES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MESSAGES = "android.permission-group.MESSAGES";
						/// <java-name>
						/// NETWORK
						/// </java-name>
						[Dot42.DexImport("NETWORK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string NETWORK = "android.permission-group.NETWORK";
						/// <java-name>
						/// PERSONAL_INFO
						/// </java-name>
						[Dot42.DexImport("PERSONAL_INFO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSONAL_INFO = "android.permission-group.PERSONAL_INFO";
						/// <java-name>
						/// PHONE_CALLS
						/// </java-name>
						[Dot42.DexImport("PHONE_CALLS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PHONE_CALLS = "android.permission-group.PHONE_CALLS";
						/// <java-name>
						/// STORAGE
						/// </java-name>
						[Dot42.DexImport("STORAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STORAGE = "android.permission-group.STORAGE";
						/// <java-name>
						/// SYSTEM_TOOLS
						/// </java-name>
						[Dot42.DexImport("SYSTEM_TOOLS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYSTEM_TOOLS = "android.permission-group.SYSTEM_TOOLS";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Permission_group() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/Manifest$permission
				/// </java-name>
				[Dot42.DexImport("android/Manifest$permission", AccessFlags = 25)]
				public sealed partial class Permission
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// ACCESS_CHECKIN_PROPERTIES
						/// </java-name>
						[Dot42.DexImport("ACCESS_CHECKIN_PROPERTIES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_CHECKIN_PROPERTIES = "android.permission.ACCESS_CHECKIN_PROPERTIES";
						/// <java-name>
						/// ACCESS_COARSE_LOCATION
						/// </java-name>
						[Dot42.DexImport("ACCESS_COARSE_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_COARSE_LOCATION = "android.permission.ACCESS_COARSE_LOCATION";
						/// <java-name>
						/// ACCESS_FINE_LOCATION
						/// </java-name>
						[Dot42.DexImport("ACCESS_FINE_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_FINE_LOCATION = "android.permission.ACCESS_FINE_LOCATION";
						/// <java-name>
						/// ACCESS_LOCATION_EXTRA_COMMANDS
						/// </java-name>
						[Dot42.DexImport("ACCESS_LOCATION_EXTRA_COMMANDS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_LOCATION_EXTRA_COMMANDS = "android.permission.ACCESS_LOCATION_EXTRA_COMMANDS";
						/// <java-name>
						/// ACCESS_MOCK_LOCATION
						/// </java-name>
						[Dot42.DexImport("ACCESS_MOCK_LOCATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_MOCK_LOCATION = "android.permission.ACCESS_MOCK_LOCATION";
						/// <java-name>
						/// ACCESS_NETWORK_STATE
						/// </java-name>
						[Dot42.DexImport("ACCESS_NETWORK_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_NETWORK_STATE = "android.permission.ACCESS_NETWORK_STATE";
						/// <java-name>
						/// ACCESS_SURFACE_FLINGER
						/// </java-name>
						[Dot42.DexImport("ACCESS_SURFACE_FLINGER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_SURFACE_FLINGER = "android.permission.ACCESS_SURFACE_FLINGER";
						/// <java-name>
						/// ACCESS_WIFI_STATE
						/// </java-name>
						[Dot42.DexImport("ACCESS_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCESS_WIFI_STATE = "android.permission.ACCESS_WIFI_STATE";
						/// <java-name>
						/// ACCOUNT_MANAGER
						/// </java-name>
						[Dot42.DexImport("ACCOUNT_MANAGER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string ACCOUNT_MANAGER = "android.permission.ACCOUNT_MANAGER";
						/// <java-name>
						/// AUTHENTICATE_ACCOUNTS
						/// </java-name>
						[Dot42.DexImport("AUTHENTICATE_ACCOUNTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string AUTHENTICATE_ACCOUNTS = "android.permission.AUTHENTICATE_ACCOUNTS";
						/// <java-name>
						/// BATTERY_STATS
						/// </java-name>
						[Dot42.DexImport("BATTERY_STATS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BATTERY_STATS = "android.permission.BATTERY_STATS";
						/// <java-name>
						/// BIND_APPWIDGET
						/// </java-name>
						[Dot42.DexImport("BIND_APPWIDGET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BIND_APPWIDGET = "android.permission.BIND_APPWIDGET";
						/// <java-name>
						/// BIND_INPUT_METHOD
						/// </java-name>
						[Dot42.DexImport("BIND_INPUT_METHOD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BIND_INPUT_METHOD = "android.permission.BIND_INPUT_METHOD";
						/// <java-name>
						/// BLUETOOTH
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH = "android.permission.BLUETOOTH";
						/// <java-name>
						/// BLUETOOTH_ADMIN
						/// </java-name>
						[Dot42.DexImport("BLUETOOTH_ADMIN", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BLUETOOTH_ADMIN = "android.permission.BLUETOOTH_ADMIN";
						/// <java-name>
						/// BRICK
						/// </java-name>
						[Dot42.DexImport("BRICK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BRICK = "android.permission.BRICK";
						/// <java-name>
						/// BROADCAST_PACKAGE_REMOVED
						/// </java-name>
						[Dot42.DexImport("BROADCAST_PACKAGE_REMOVED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BROADCAST_PACKAGE_REMOVED = "android.permission.BROADCAST_PACKAGE_REMOVED";
						/// <java-name>
						/// BROADCAST_SMS
						/// </java-name>
						[Dot42.DexImport("BROADCAST_SMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BROADCAST_SMS = "android.permission.BROADCAST_SMS";
						/// <java-name>
						/// BROADCAST_STICKY
						/// </java-name>
						[Dot42.DexImport("BROADCAST_STICKY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BROADCAST_STICKY = "android.permission.BROADCAST_STICKY";
						/// <java-name>
						/// BROADCAST_WAP_PUSH
						/// </java-name>
						[Dot42.DexImport("BROADCAST_WAP_PUSH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string BROADCAST_WAP_PUSH = "android.permission.BROADCAST_WAP_PUSH";
						/// <java-name>
						/// CALL_PHONE
						/// </java-name>
						[Dot42.DexImport("CALL_PHONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALL_PHONE = "android.permission.CALL_PHONE";
						/// <java-name>
						/// CALL_PRIVILEGED
						/// </java-name>
						[Dot42.DexImport("CALL_PRIVILEGED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CALL_PRIVILEGED = "android.permission.CALL_PRIVILEGED";
						/// <java-name>
						/// CAMERA
						/// </java-name>
						[Dot42.DexImport("CAMERA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CAMERA = "android.permission.CAMERA";
						/// <java-name>
						/// CHANGE_COMPONENT_ENABLED_STATE
						/// </java-name>
						[Dot42.DexImport("CHANGE_COMPONENT_ENABLED_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHANGE_COMPONENT_ENABLED_STATE = "android.permission.CHANGE_COMPONENT_ENABLED_STATE";
						/// <java-name>
						/// CHANGE_CONFIGURATION
						/// </java-name>
						[Dot42.DexImport("CHANGE_CONFIGURATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHANGE_CONFIGURATION = "android.permission.CHANGE_CONFIGURATION";
						/// <java-name>
						/// CHANGE_NETWORK_STATE
						/// </java-name>
						[Dot42.DexImport("CHANGE_NETWORK_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHANGE_NETWORK_STATE = "android.permission.CHANGE_NETWORK_STATE";
						/// <java-name>
						/// CHANGE_WIFI_MULTICAST_STATE
						/// </java-name>
						[Dot42.DexImport("CHANGE_WIFI_MULTICAST_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHANGE_WIFI_MULTICAST_STATE = "android.permission.CHANGE_WIFI_MULTICAST_STATE";
						/// <java-name>
						/// CHANGE_WIFI_STATE
						/// </java-name>
						[Dot42.DexImport("CHANGE_WIFI_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CHANGE_WIFI_STATE = "android.permission.CHANGE_WIFI_STATE";
						/// <java-name>
						/// CLEAR_APP_CACHE
						/// </java-name>
						[Dot42.DexImport("CLEAR_APP_CACHE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CLEAR_APP_CACHE = "android.permission.CLEAR_APP_CACHE";
						/// <java-name>
						/// CLEAR_APP_USER_DATA
						/// </java-name>
						[Dot42.DexImport("CLEAR_APP_USER_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CLEAR_APP_USER_DATA = "android.permission.CLEAR_APP_USER_DATA";
						/// <java-name>
						/// CONTROL_LOCATION_UPDATES
						/// </java-name>
						[Dot42.DexImport("CONTROL_LOCATION_UPDATES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string CONTROL_LOCATION_UPDATES = "android.permission.CONTROL_LOCATION_UPDATES";
						/// <java-name>
						/// DELETE_CACHE_FILES
						/// </java-name>
						[Dot42.DexImport("DELETE_CACHE_FILES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETE_CACHE_FILES = "android.permission.DELETE_CACHE_FILES";
						/// <java-name>
						/// DELETE_PACKAGES
						/// </java-name>
						[Dot42.DexImport("DELETE_PACKAGES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DELETE_PACKAGES = "android.permission.DELETE_PACKAGES";
						/// <java-name>
						/// DEVICE_POWER
						/// </java-name>
						[Dot42.DexImport("DEVICE_POWER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DEVICE_POWER = "android.permission.DEVICE_POWER";
						/// <java-name>
						/// DIAGNOSTIC
						/// </java-name>
						[Dot42.DexImport("DIAGNOSTIC", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DIAGNOSTIC = "android.permission.DIAGNOSTIC";
						/// <java-name>
						/// DISABLE_KEYGUARD
						/// </java-name>
						[Dot42.DexImport("DISABLE_KEYGUARD", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DISABLE_KEYGUARD = "android.permission.DISABLE_KEYGUARD";
						/// <java-name>
						/// DUMP
						/// </java-name>
						[Dot42.DexImport("DUMP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string DUMP = "android.permission.DUMP";
						/// <java-name>
						/// EXPAND_STATUS_BAR
						/// </java-name>
						[Dot42.DexImport("EXPAND_STATUS_BAR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string EXPAND_STATUS_BAR = "android.permission.EXPAND_STATUS_BAR";
						/// <java-name>
						/// FACTORY_TEST
						/// </java-name>
						[Dot42.DexImport("FACTORY_TEST", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FACTORY_TEST = "android.permission.FACTORY_TEST";
						/// <java-name>
						/// FLASHLIGHT
						/// </java-name>
						[Dot42.DexImport("FLASHLIGHT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FLASHLIGHT = "android.permission.FLASHLIGHT";
						/// <java-name>
						/// FORCE_BACK
						/// </java-name>
						[Dot42.DexImport("FORCE_BACK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string FORCE_BACK = "android.permission.FORCE_BACK";
						/// <java-name>
						/// GET_ACCOUNTS
						/// </java-name>
						[Dot42.DexImport("GET_ACCOUNTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GET_ACCOUNTS = "android.permission.GET_ACCOUNTS";
						/// <java-name>
						/// GET_PACKAGE_SIZE
						/// </java-name>
						[Dot42.DexImport("GET_PACKAGE_SIZE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GET_PACKAGE_SIZE = "android.permission.GET_PACKAGE_SIZE";
						/// <java-name>
						/// GET_TASKS
						/// </java-name>
						[Dot42.DexImport("GET_TASKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GET_TASKS = "android.permission.GET_TASKS";
						/// <java-name>
						/// GLOBAL_SEARCH
						/// </java-name>
						[Dot42.DexImport("GLOBAL_SEARCH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string GLOBAL_SEARCH = "android.permission.GLOBAL_SEARCH";
						/// <java-name>
						/// HARDWARE_TEST
						/// </java-name>
						[Dot42.DexImport("HARDWARE_TEST", "Ljava/lang/String;", AccessFlags = 25)]
						public const string HARDWARE_TEST = "android.permission.HARDWARE_TEST";
						/// <java-name>
						/// INJECT_EVENTS
						/// </java-name>
						[Dot42.DexImport("INJECT_EVENTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INJECT_EVENTS = "android.permission.INJECT_EVENTS";
						/// <java-name>
						/// INSTALL_LOCATION_PROVIDER
						/// </java-name>
						[Dot42.DexImport("INSTALL_LOCATION_PROVIDER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INSTALL_LOCATION_PROVIDER = "android.permission.INSTALL_LOCATION_PROVIDER";
						/// <java-name>
						/// INSTALL_PACKAGES
						/// </java-name>
						[Dot42.DexImport("INSTALL_PACKAGES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INSTALL_PACKAGES = "android.permission.INSTALL_PACKAGES";
						/// <java-name>
						/// INTERNAL_SYSTEM_WINDOW
						/// </java-name>
						[Dot42.DexImport("INTERNAL_SYSTEM_WINDOW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INTERNAL_SYSTEM_WINDOW = "android.permission.INTERNAL_SYSTEM_WINDOW";
						/// <java-name>
						/// INTERNET
						/// </java-name>
						[Dot42.DexImport("INTERNET", "Ljava/lang/String;", AccessFlags = 25)]
						public const string INTERNET = "android.permission.INTERNET";
						/// <java-name>
						/// MANAGE_ACCOUNTS
						/// </java-name>
						[Dot42.DexImport("MANAGE_ACCOUNTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MANAGE_ACCOUNTS = "android.permission.MANAGE_ACCOUNTS";
						/// <java-name>
						/// MANAGE_APP_TOKENS
						/// </java-name>
						[Dot42.DexImport("MANAGE_APP_TOKENS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MANAGE_APP_TOKENS = "android.permission.MANAGE_APP_TOKENS";
						/// <java-name>
						/// MASTER_CLEAR
						/// </java-name>
						[Dot42.DexImport("MASTER_CLEAR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MASTER_CLEAR = "android.permission.MASTER_CLEAR";
						/// <java-name>
						/// MODIFY_AUDIO_SETTINGS
						/// </java-name>
						[Dot42.DexImport("MODIFY_AUDIO_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODIFY_AUDIO_SETTINGS = "android.permission.MODIFY_AUDIO_SETTINGS";
						/// <java-name>
						/// MODIFY_PHONE_STATE
						/// </java-name>
						[Dot42.DexImport("MODIFY_PHONE_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MODIFY_PHONE_STATE = "android.permission.MODIFY_PHONE_STATE";
						/// <java-name>
						/// MOUNT_FORMAT_FILESYSTEMS
						/// </java-name>
						[Dot42.DexImport("MOUNT_FORMAT_FILESYSTEMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MOUNT_FORMAT_FILESYSTEMS = "android.permission.MOUNT_FORMAT_FILESYSTEMS";
						/// <java-name>
						/// MOUNT_UNMOUNT_FILESYSTEMS
						/// </java-name>
						[Dot42.DexImport("MOUNT_UNMOUNT_FILESYSTEMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string MOUNT_UNMOUNT_FILESYSTEMS = "android.permission.MOUNT_UNMOUNT_FILESYSTEMS";
						/// <java-name>
						/// PERSISTENT_ACTIVITY
						/// </java-name>
						[Dot42.DexImport("PERSISTENT_ACTIVITY", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PERSISTENT_ACTIVITY = "android.permission.PERSISTENT_ACTIVITY";
						/// <java-name>
						/// PROCESS_OUTGOING_CALLS
						/// </java-name>
						[Dot42.DexImport("PROCESS_OUTGOING_CALLS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string PROCESS_OUTGOING_CALLS = "android.permission.PROCESS_OUTGOING_CALLS";
						/// <java-name>
						/// READ_CALENDAR
						/// </java-name>
						[Dot42.DexImport("READ_CALENDAR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_CALENDAR = "android.permission.READ_CALENDAR";
						/// <java-name>
						/// READ_CONTACTS
						/// </java-name>
						[Dot42.DexImport("READ_CONTACTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_CONTACTS = "android.permission.READ_CONTACTS";
						/// <java-name>
						/// READ_FRAME_BUFFER
						/// </java-name>
						[Dot42.DexImport("READ_FRAME_BUFFER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_FRAME_BUFFER = "android.permission.READ_FRAME_BUFFER";
						/// <java-name>
						/// READ_HISTORY_BOOKMARKS
						/// </java-name>
						[Dot42.DexImport("READ_HISTORY_BOOKMARKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_HISTORY_BOOKMARKS = "com.android.browser.permission.READ_HISTORY_BOOKMARKS";
						/// <java-name>
						/// READ_INPUT_STATE
						/// </java-name>
						[Dot42.DexImport("READ_INPUT_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_INPUT_STATE = "android.permission.READ_INPUT_STATE";
						/// <java-name>
						/// READ_LOGS
						/// </java-name>
						[Dot42.DexImport("READ_LOGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_LOGS = "android.permission.READ_LOGS";
						/// <java-name>
						/// READ_OWNER_DATA
						/// </java-name>
						[Dot42.DexImport("READ_OWNER_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_OWNER_DATA = "android.permission.READ_OWNER_DATA";
						/// <java-name>
						/// READ_PHONE_STATE
						/// </java-name>
						[Dot42.DexImport("READ_PHONE_STATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_PHONE_STATE = "android.permission.READ_PHONE_STATE";
						/// <java-name>
						/// READ_SMS
						/// </java-name>
						[Dot42.DexImport("READ_SMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_SMS = "android.permission.READ_SMS";
						/// <java-name>
						/// READ_SYNC_SETTINGS
						/// </java-name>
						[Dot42.DexImport("READ_SYNC_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_SYNC_SETTINGS = "android.permission.READ_SYNC_SETTINGS";
						/// <java-name>
						/// READ_SYNC_STATS
						/// </java-name>
						[Dot42.DexImport("READ_SYNC_STATS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string READ_SYNC_STATS = "android.permission.READ_SYNC_STATS";
						/// <java-name>
						/// REBOOT
						/// </java-name>
						[Dot42.DexImport("REBOOT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string REBOOT = "android.permission.REBOOT";
						/// <java-name>
						/// RECEIVE_BOOT_COMPLETED
						/// </java-name>
						[Dot42.DexImport("RECEIVE_BOOT_COMPLETED", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RECEIVE_BOOT_COMPLETED = "android.permission.RECEIVE_BOOT_COMPLETED";
						/// <java-name>
						/// RECEIVE_MMS
						/// </java-name>
						[Dot42.DexImport("RECEIVE_MMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RECEIVE_MMS = "android.permission.RECEIVE_MMS";
						/// <java-name>
						/// RECEIVE_SMS
						/// </java-name>
						[Dot42.DexImport("RECEIVE_SMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RECEIVE_SMS = "android.permission.RECEIVE_SMS";
						/// <java-name>
						/// RECEIVE_WAP_PUSH
						/// </java-name>
						[Dot42.DexImport("RECEIVE_WAP_PUSH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RECEIVE_WAP_PUSH = "android.permission.RECEIVE_WAP_PUSH";
						/// <java-name>
						/// RECORD_AUDIO
						/// </java-name>
						[Dot42.DexImport("RECORD_AUDIO", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RECORD_AUDIO = "android.permission.RECORD_AUDIO";
						/// <java-name>
						/// REORDER_TASKS
						/// </java-name>
						[Dot42.DexImport("REORDER_TASKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string REORDER_TASKS = "android.permission.REORDER_TASKS";
						/// <java-name>
						/// RESTART_PACKAGES
						/// </java-name>
						[Dot42.DexImport("RESTART_PACKAGES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string RESTART_PACKAGES = "android.permission.RESTART_PACKAGES";
						/// <java-name>
						/// SEND_SMS
						/// </java-name>
						[Dot42.DexImport("SEND_SMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SEND_SMS = "android.permission.SEND_SMS";
						/// <java-name>
						/// SET_ACTIVITY_WATCHER
						/// </java-name>
						[Dot42.DexImport("SET_ACTIVITY_WATCHER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_ACTIVITY_WATCHER = "android.permission.SET_ACTIVITY_WATCHER";
						/// <java-name>
						/// SET_ALWAYS_FINISH
						/// </java-name>
						[Dot42.DexImport("SET_ALWAYS_FINISH", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_ALWAYS_FINISH = "android.permission.SET_ALWAYS_FINISH";
						/// <java-name>
						/// SET_ANIMATION_SCALE
						/// </java-name>
						[Dot42.DexImport("SET_ANIMATION_SCALE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_ANIMATION_SCALE = "android.permission.SET_ANIMATION_SCALE";
						/// <java-name>
						/// SET_DEBUG_APP
						/// </java-name>
						[Dot42.DexImport("SET_DEBUG_APP", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_DEBUG_APP = "android.permission.SET_DEBUG_APP";
						/// <java-name>
						/// SET_ORIENTATION
						/// </java-name>
						[Dot42.DexImport("SET_ORIENTATION", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_ORIENTATION = "android.permission.SET_ORIENTATION";
						/// <java-name>
						/// SET_PREFERRED_APPLICATIONS
						/// </java-name>
						[Dot42.DexImport("SET_PREFERRED_APPLICATIONS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_PREFERRED_APPLICATIONS = "android.permission.SET_PREFERRED_APPLICATIONS";
						/// <java-name>
						/// SET_PROCESS_LIMIT
						/// </java-name>
						[Dot42.DexImport("SET_PROCESS_LIMIT", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_PROCESS_LIMIT = "android.permission.SET_PROCESS_LIMIT";
						/// <java-name>
						/// SET_TIME_ZONE
						/// </java-name>
						[Dot42.DexImport("SET_TIME_ZONE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_TIME_ZONE = "android.permission.SET_TIME_ZONE";
						/// <java-name>
						/// SET_WALLPAPER
						/// </java-name>
						[Dot42.DexImport("SET_WALLPAPER", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_WALLPAPER = "android.permission.SET_WALLPAPER";
						/// <java-name>
						/// SET_WALLPAPER_HINTS
						/// </java-name>
						[Dot42.DexImport("SET_WALLPAPER_HINTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SET_WALLPAPER_HINTS = "android.permission.SET_WALLPAPER_HINTS";
						/// <java-name>
						/// SIGNAL_PERSISTENT_PROCESSES
						/// </java-name>
						[Dot42.DexImport("SIGNAL_PERSISTENT_PROCESSES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SIGNAL_PERSISTENT_PROCESSES = "android.permission.SIGNAL_PERSISTENT_PROCESSES";
						/// <java-name>
						/// STATUS_BAR
						/// </java-name>
						[Dot42.DexImport("STATUS_BAR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string STATUS_BAR = "android.permission.STATUS_BAR";
						/// <java-name>
						/// SUBSCRIBED_FEEDS_READ
						/// </java-name>
						[Dot42.DexImport("SUBSCRIBED_FEEDS_READ", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SUBSCRIBED_FEEDS_READ = "android.permission.SUBSCRIBED_FEEDS_READ";
						/// <java-name>
						/// SUBSCRIBED_FEEDS_WRITE
						/// </java-name>
						[Dot42.DexImport("SUBSCRIBED_FEEDS_WRITE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SUBSCRIBED_FEEDS_WRITE = "android.permission.SUBSCRIBED_FEEDS_WRITE";
						/// <java-name>
						/// SYSTEM_ALERT_WINDOW
						/// </java-name>
						[Dot42.DexImport("SYSTEM_ALERT_WINDOW", "Ljava/lang/String;", AccessFlags = 25)]
						public const string SYSTEM_ALERT_WINDOW = "android.permission.SYSTEM_ALERT_WINDOW";
						/// <java-name>
						/// UPDATE_DEVICE_STATS
						/// </java-name>
						[Dot42.DexImport("UPDATE_DEVICE_STATS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string UPDATE_DEVICE_STATS = "android.permission.UPDATE_DEVICE_STATS";
						/// <java-name>
						/// USE_CREDENTIALS
						/// </java-name>
						[Dot42.DexImport("USE_CREDENTIALS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string USE_CREDENTIALS = "android.permission.USE_CREDENTIALS";
						/// <java-name>
						/// VIBRATE
						/// </java-name>
						[Dot42.DexImport("VIBRATE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string VIBRATE = "android.permission.VIBRATE";
						/// <java-name>
						/// WAKE_LOCK
						/// </java-name>
						[Dot42.DexImport("WAKE_LOCK", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WAKE_LOCK = "android.permission.WAKE_LOCK";
						/// <java-name>
						/// WRITE_APN_SETTINGS
						/// </java-name>
						[Dot42.DexImport("WRITE_APN_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_APN_SETTINGS = "android.permission.WRITE_APN_SETTINGS";
						/// <java-name>
						/// WRITE_CALENDAR
						/// </java-name>
						[Dot42.DexImport("WRITE_CALENDAR", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_CALENDAR = "android.permission.WRITE_CALENDAR";
						/// <java-name>
						/// WRITE_CONTACTS
						/// </java-name>
						[Dot42.DexImport("WRITE_CONTACTS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_CONTACTS = "android.permission.WRITE_CONTACTS";
						/// <java-name>
						/// WRITE_EXTERNAL_STORAGE
						/// </java-name>
						[Dot42.DexImport("WRITE_EXTERNAL_STORAGE", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_EXTERNAL_STORAGE = "android.permission.WRITE_EXTERNAL_STORAGE";
						/// <java-name>
						/// WRITE_GSERVICES
						/// </java-name>
						[Dot42.DexImport("WRITE_GSERVICES", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_GSERVICES = "android.permission.WRITE_GSERVICES";
						/// <java-name>
						/// WRITE_HISTORY_BOOKMARKS
						/// </java-name>
						[Dot42.DexImport("WRITE_HISTORY_BOOKMARKS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_HISTORY_BOOKMARKS = "com.android.browser.permission.WRITE_HISTORY_BOOKMARKS";
						/// <java-name>
						/// WRITE_OWNER_DATA
						/// </java-name>
						[Dot42.DexImport("WRITE_OWNER_DATA", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_OWNER_DATA = "android.permission.WRITE_OWNER_DATA";
						/// <java-name>
						/// WRITE_SECURE_SETTINGS
						/// </java-name>
						[Dot42.DexImport("WRITE_SECURE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_SECURE_SETTINGS = "android.permission.WRITE_SECURE_SETTINGS";
						/// <java-name>
						/// WRITE_SETTINGS
						/// </java-name>
						[Dot42.DexImport("WRITE_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_SETTINGS = "android.permission.WRITE_SETTINGS";
						/// <java-name>
						/// WRITE_SMS
						/// </java-name>
						[Dot42.DexImport("WRITE_SMS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_SMS = "android.permission.WRITE_SMS";
						/// <java-name>
						/// WRITE_SYNC_SETTINGS
						/// </java-name>
						[Dot42.DexImport("WRITE_SYNC_SETTINGS", "Ljava/lang/String;", AccessFlags = 25)]
						public const string WRITE_SYNC_SETTINGS = "android.permission.WRITE_SYNC_SETTINGS";
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Permission() /* MethodBuilder.Create */ 
						{
						}

				}

		}

		/// <java-name>
		/// android/R
		/// </java-name>
		[Dot42.DexImport("android/R", AccessFlags = 49)]
		public sealed partial class R
 /* scope: __dot42__ */ 
		{
				[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
				public R() /* MethodBuilder.Create */ 
				{
				}

				/// <java-name>
				/// android/R$xml
				/// </java-name>
				[Dot42.DexImport("android/R$xml", AccessFlags = 25)]
				public sealed partial class Xml
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Xml() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$style
				/// </java-name>
				[Dot42.DexImport("android/R$style", AccessFlags = 25)]
				public sealed partial class Style
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// Animation
						/// </java-name>
						[Dot42.DexImport("Animation", "I", AccessFlags = 25)]
						public const int Animation = 16973824;
						/// <java-name>
						/// Animation_Activity
						/// </java-name>
						[Dot42.DexImport("Animation_Activity", "I", AccessFlags = 25)]
						public const int Animation_Activity = 16973825;
						/// <java-name>
						/// Animation_Dialog
						/// </java-name>
						[Dot42.DexImport("Animation_Dialog", "I", AccessFlags = 25)]
						public const int Animation_Dialog = 16973826;
						/// <java-name>
						/// Animation_InputMethod
						/// </java-name>
						[Dot42.DexImport("Animation_InputMethod", "I", AccessFlags = 25)]
						public const int Animation_InputMethod = 16973910;
						/// <java-name>
						/// Animation_Toast
						/// </java-name>
						[Dot42.DexImport("Animation_Toast", "I", AccessFlags = 25)]
						public const int Animation_Toast = 16973828;
						/// <java-name>
						/// Animation_Translucent
						/// </java-name>
						[Dot42.DexImport("Animation_Translucent", "I", AccessFlags = 25)]
						public const int Animation_Translucent = 16973827;
						/// <java-name>
						/// MediaButton
						/// </java-name>
						[Dot42.DexImport("MediaButton", "I", AccessFlags = 25)]
						public const int MediaButton = 16973879;
						/// <java-name>
						/// MediaButton_Ffwd
						/// </java-name>
						[Dot42.DexImport("MediaButton_Ffwd", "I", AccessFlags = 25)]
						public const int MediaButton_Ffwd = 16973883;
						/// <java-name>
						/// MediaButton_Next
						/// </java-name>
						[Dot42.DexImport("MediaButton_Next", "I", AccessFlags = 25)]
						public const int MediaButton_Next = 16973881;
						/// <java-name>
						/// MediaButton_Pause
						/// </java-name>
						[Dot42.DexImport("MediaButton_Pause", "I", AccessFlags = 25)]
						public const int MediaButton_Pause = 16973885;
						/// <java-name>
						/// MediaButton_Play
						/// </java-name>
						[Dot42.DexImport("MediaButton_Play", "I", AccessFlags = 25)]
						public const int MediaButton_Play = 16973882;
						/// <java-name>
						/// MediaButton_Previous
						/// </java-name>
						[Dot42.DexImport("MediaButton_Previous", "I", AccessFlags = 25)]
						public const int MediaButton_Previous = 16973880;
						/// <java-name>
						/// MediaButton_Rew
						/// </java-name>
						[Dot42.DexImport("MediaButton_Rew", "I", AccessFlags = 25)]
						public const int MediaButton_Rew = 16973884;
						/// <java-name>
						/// TextAppearance
						/// </java-name>
						[Dot42.DexImport("TextAppearance", "I", AccessFlags = 25)]
						public const int TextAppearance = 16973886;
						/// <java-name>
						/// TextAppearance_DialogWindowTitle
						/// </java-name>
						[Dot42.DexImport("TextAppearance_DialogWindowTitle", "I", AccessFlags = 25)]
						public const int TextAppearance_DialogWindowTitle = 16973889;
						/// <java-name>
						/// TextAppearance_Inverse
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Inverse", "I", AccessFlags = 25)]
						public const int TextAppearance_Inverse = 16973887;
						/// <java-name>
						/// TextAppearance_Large
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Large", "I", AccessFlags = 25)]
						public const int TextAppearance_Large = 16973890;
						/// <java-name>
						/// TextAppearance_Large_Inverse
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Large_Inverse", "I", AccessFlags = 25)]
						public const int TextAppearance_Large_Inverse = 16973891;
						/// <java-name>
						/// TextAppearance_Medium
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Medium", "I", AccessFlags = 25)]
						public const int TextAppearance_Medium = 16973892;
						/// <java-name>
						/// TextAppearance_Medium_Inverse
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Medium_Inverse", "I", AccessFlags = 25)]
						public const int TextAppearance_Medium_Inverse = 16973893;
						/// <java-name>
						/// TextAppearance_Small
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Small", "I", AccessFlags = 25)]
						public const int TextAppearance_Small = 16973894;
						/// <java-name>
						/// TextAppearance_Small_Inverse
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Small_Inverse", "I", AccessFlags = 25)]
						public const int TextAppearance_Small_Inverse = 16973895;
						/// <java-name>
						/// TextAppearance_Theme
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Theme", "I", AccessFlags = 25)]
						public const int TextAppearance_Theme = 16973888;
						/// <java-name>
						/// TextAppearance_Theme_Dialog
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Theme_Dialog", "I", AccessFlags = 25)]
						public const int TextAppearance_Theme_Dialog = 16973896;
						/// <java-name>
						/// TextAppearance_Widget
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget = 16973897;
						/// <java-name>
						/// TextAppearance_Widget_Button
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_Button", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_Button = 16973898;
						/// <java-name>
						/// TextAppearance_Widget_DropDownHint
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_DropDownHint", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_DropDownHint = 16973904;
						/// <java-name>
						/// TextAppearance_Widget_DropDownItem
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_DropDownItem", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_DropDownItem = 16973905;
						/// <java-name>
						/// TextAppearance_Widget_EditText
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_EditText", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_EditText = 16973900;
						/// <java-name>
						/// TextAppearance_Widget_IconMenu_Item
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_IconMenu_Item", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_IconMenu_Item = 16973899;
						/// <java-name>
						/// TextAppearance_Widget_TabWidget
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_TabWidget", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_TabWidget = 16973901;
						/// <java-name>
						/// TextAppearance_Widget_TextView
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_TextView", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_TextView = 16973902;
						/// <java-name>
						/// TextAppearance_Widget_TextView_PopupMenu
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_TextView_PopupMenu", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_TextView_PopupMenu = 16973903;
						/// <java-name>
						/// TextAppearance_Widget_TextView_SpinnerItem
						/// </java-name>
						[Dot42.DexImport("TextAppearance_Widget_TextView_SpinnerItem", "I", AccessFlags = 25)]
						public const int TextAppearance_Widget_TextView_SpinnerItem = 16973906;
						/// <java-name>
						/// TextAppearance_WindowTitle
						/// </java-name>
						[Dot42.DexImport("TextAppearance_WindowTitle", "I", AccessFlags = 25)]
						public const int TextAppearance_WindowTitle = 16973907;
						/// <java-name>
						/// Theme
						/// </java-name>
						[Dot42.DexImport("Theme", "I", AccessFlags = 25)]
						public const int Theme = 16973829;
						/// <java-name>
						/// Theme_Black
						/// </java-name>
						[Dot42.DexImport("Theme_Black", "I", AccessFlags = 25)]
						public const int Theme_Black = 16973832;
						/// <java-name>
						/// Theme_Black_NoTitleBar
						/// </java-name>
						[Dot42.DexImport("Theme_Black_NoTitleBar", "I", AccessFlags = 25)]
						public const int Theme_Black_NoTitleBar = 16973833;
						/// <java-name>
						/// Theme_Black_NoTitleBar_Fullscreen
						/// </java-name>
						[Dot42.DexImport("Theme_Black_NoTitleBar_Fullscreen", "I", AccessFlags = 25)]
						public const int Theme_Black_NoTitleBar_Fullscreen = 16973834;
						/// <java-name>
						/// Theme_Dialog
						/// </java-name>
						[Dot42.DexImport("Theme_Dialog", "I", AccessFlags = 25)]
						public const int Theme_Dialog = 16973835;
						/// <java-name>
						/// Theme_InputMethod
						/// </java-name>
						[Dot42.DexImport("Theme_InputMethod", "I", AccessFlags = 25)]
						public const int Theme_InputMethod = 16973908;
						/// <java-name>
						/// Theme_Light
						/// </java-name>
						[Dot42.DexImport("Theme_Light", "I", AccessFlags = 25)]
						public const int Theme_Light = 16973836;
						/// <java-name>
						/// Theme_Light_NoTitleBar
						/// </java-name>
						[Dot42.DexImport("Theme_Light_NoTitleBar", "I", AccessFlags = 25)]
						public const int Theme_Light_NoTitleBar = 16973837;
						/// <java-name>
						/// Theme_Light_NoTitleBar_Fullscreen
						/// </java-name>
						[Dot42.DexImport("Theme_Light_NoTitleBar_Fullscreen", "I", AccessFlags = 25)]
						public const int Theme_Light_NoTitleBar_Fullscreen = 16973838;
						/// <java-name>
						/// Theme_Light_Panel
						/// </java-name>
						[Dot42.DexImport("Theme_Light_Panel", "I", AccessFlags = 25)]
						public const int Theme_Light_Panel = 16973914;
						/// <java-name>
						/// Theme_Light_WallpaperSettings
						/// </java-name>
						[Dot42.DexImport("Theme_Light_WallpaperSettings", "I", AccessFlags = 25)]
						public const int Theme_Light_WallpaperSettings = 16973922;
						/// <java-name>
						/// Theme_NoDisplay
						/// </java-name>
						[Dot42.DexImport("Theme_NoDisplay", "I", AccessFlags = 25)]
						public const int Theme_NoDisplay = 16973909;
						/// <java-name>
						/// Theme_NoTitleBar
						/// </java-name>
						[Dot42.DexImport("Theme_NoTitleBar", "I", AccessFlags = 25)]
						public const int Theme_NoTitleBar = 16973830;
						/// <java-name>
						/// Theme_NoTitleBar_Fullscreen
						/// </java-name>
						[Dot42.DexImport("Theme_NoTitleBar_Fullscreen", "I", AccessFlags = 25)]
						public const int Theme_NoTitleBar_Fullscreen = 16973831;
						/// <java-name>
						/// Theme_Panel
						/// </java-name>
						[Dot42.DexImport("Theme_Panel", "I", AccessFlags = 25)]
						public const int Theme_Panel = 16973913;
						/// <java-name>
						/// Theme_Translucent
						/// </java-name>
						[Dot42.DexImport("Theme_Translucent", "I", AccessFlags = 25)]
						public const int Theme_Translucent = 16973839;
						/// <java-name>
						/// Theme_Translucent_NoTitleBar
						/// </java-name>
						[Dot42.DexImport("Theme_Translucent_NoTitleBar", "I", AccessFlags = 25)]
						public const int Theme_Translucent_NoTitleBar = 16973840;
						/// <java-name>
						/// Theme_Translucent_NoTitleBar_Fullscreen
						/// </java-name>
						[Dot42.DexImport("Theme_Translucent_NoTitleBar_Fullscreen", "I", AccessFlags = 25)]
						public const int Theme_Translucent_NoTitleBar_Fullscreen = 16973841;
						/// <java-name>
						/// Theme_Wallpaper
						/// </java-name>
						[Dot42.DexImport("Theme_Wallpaper", "I", AccessFlags = 25)]
						public const int Theme_Wallpaper = 16973918;
						/// <java-name>
						/// Theme_Wallpaper_NoTitleBar
						/// </java-name>
						[Dot42.DexImport("Theme_Wallpaper_NoTitleBar", "I", AccessFlags = 25)]
						public const int Theme_Wallpaper_NoTitleBar = 16973919;
						/// <java-name>
						/// Theme_Wallpaper_NoTitleBar_Fullscreen
						/// </java-name>
						[Dot42.DexImport("Theme_Wallpaper_NoTitleBar_Fullscreen", "I", AccessFlags = 25)]
						public const int Theme_Wallpaper_NoTitleBar_Fullscreen = 16973920;
						/// <java-name>
						/// Theme_WallpaperSettings
						/// </java-name>
						[Dot42.DexImport("Theme_WallpaperSettings", "I", AccessFlags = 25)]
						public const int Theme_WallpaperSettings = 16973921;
						/// <java-name>
						/// Widget
						/// </java-name>
						[Dot42.DexImport("Widget", "I", AccessFlags = 25)]
						public const int Widget = 16973842;
						/// <java-name>
						/// Widget_AbsListView
						/// </java-name>
						[Dot42.DexImport("Widget_AbsListView", "I", AccessFlags = 25)]
						public const int Widget_AbsListView = 16973843;
						/// <java-name>
						/// Widget_AutoCompleteTextView
						/// </java-name>
						[Dot42.DexImport("Widget_AutoCompleteTextView", "I", AccessFlags = 25)]
						public const int Widget_AutoCompleteTextView = 16973863;
						/// <java-name>
						/// Widget_Button
						/// </java-name>
						[Dot42.DexImport("Widget_Button", "I", AccessFlags = 25)]
						public const int Widget_Button = 16973844;
						/// <java-name>
						/// Widget_Button_Inset
						/// </java-name>
						[Dot42.DexImport("Widget_Button_Inset", "I", AccessFlags = 25)]
						public const int Widget_Button_Inset = 16973845;
						/// <java-name>
						/// Widget_Button_Small
						/// </java-name>
						[Dot42.DexImport("Widget_Button_Small", "I", AccessFlags = 25)]
						public const int Widget_Button_Small = 16973846;
						/// <java-name>
						/// Widget_Button_Toggle
						/// </java-name>
						[Dot42.DexImport("Widget_Button_Toggle", "I", AccessFlags = 25)]
						public const int Widget_Button_Toggle = 16973847;
						/// <java-name>
						/// Widget_CompoundButton
						/// </java-name>
						[Dot42.DexImport("Widget_CompoundButton", "I", AccessFlags = 25)]
						public const int Widget_CompoundButton = 16973848;
						/// <java-name>
						/// Widget_CompoundButton_CheckBox
						/// </java-name>
						[Dot42.DexImport("Widget_CompoundButton_CheckBox", "I", AccessFlags = 25)]
						public const int Widget_CompoundButton_CheckBox = 16973849;
						/// <java-name>
						/// Widget_CompoundButton_RadioButton
						/// </java-name>
						[Dot42.DexImport("Widget_CompoundButton_RadioButton", "I", AccessFlags = 25)]
						public const int Widget_CompoundButton_RadioButton = 16973850;
						/// <java-name>
						/// Widget_CompoundButton_Star
						/// </java-name>
						[Dot42.DexImport("Widget_CompoundButton_Star", "I", AccessFlags = 25)]
						public const int Widget_CompoundButton_Star = 16973851;
						/// <java-name>
						/// Widget_DropDownItem
						/// </java-name>
						[Dot42.DexImport("Widget_DropDownItem", "I", AccessFlags = 25)]
						public const int Widget_DropDownItem = 16973867;
						/// <java-name>
						/// Widget_DropDownItem_Spinner
						/// </java-name>
						[Dot42.DexImport("Widget_DropDownItem_Spinner", "I", AccessFlags = 25)]
						public const int Widget_DropDownItem_Spinner = 16973868;
						/// <java-name>
						/// Widget_EditText
						/// </java-name>
						[Dot42.DexImport("Widget_EditText", "I", AccessFlags = 25)]
						public const int Widget_EditText = 16973859;
						/// <java-name>
						/// Widget_ExpandableListView
						/// </java-name>
						[Dot42.DexImport("Widget_ExpandableListView", "I", AccessFlags = 25)]
						public const int Widget_ExpandableListView = 16973860;
						/// <java-name>
						/// Widget_Gallery
						/// </java-name>
						[Dot42.DexImport("Widget_Gallery", "I", AccessFlags = 25)]
						public const int Widget_Gallery = 16973877;
						/// <java-name>
						/// Widget_GridView
						/// </java-name>
						[Dot42.DexImport("Widget_GridView", "I", AccessFlags = 25)]
						public const int Widget_GridView = 16973874;
						/// <java-name>
						/// Widget_ImageButton
						/// </java-name>
						[Dot42.DexImport("Widget_ImageButton", "I", AccessFlags = 25)]
						public const int Widget_ImageButton = 16973862;
						/// <java-name>
						/// Widget_ImageWell
						/// </java-name>
						[Dot42.DexImport("Widget_ImageWell", "I", AccessFlags = 25)]
						public const int Widget_ImageWell = 16973861;
						/// <java-name>
						/// Widget_KeyboardView
						/// </java-name>
						[Dot42.DexImport("Widget_KeyboardView", "I", AccessFlags = 25)]
						public const int Widget_KeyboardView = 16973911;
						/// <java-name>
						/// Widget_ListView
						/// </java-name>
						[Dot42.DexImport("Widget_ListView", "I", AccessFlags = 25)]
						public const int Widget_ListView = 16973870;
						/// <java-name>
						/// Widget_ListView_DropDown
						/// </java-name>
						[Dot42.DexImport("Widget_ListView_DropDown", "I", AccessFlags = 25)]
						public const int Widget_ListView_DropDown = 16973872;
						/// <java-name>
						/// Widget_ListView_Menu
						/// </java-name>
						[Dot42.DexImport("Widget_ListView_Menu", "I", AccessFlags = 25)]
						public const int Widget_ListView_Menu = 16973873;
						/// <java-name>
						/// Widget_ListView_White
						/// </java-name>
						[Dot42.DexImport("Widget_ListView_White", "I", AccessFlags = 25)]
						public const int Widget_ListView_White = 16973871;
						/// <java-name>
						/// Widget_PopupWindow
						/// </java-name>
						[Dot42.DexImport("Widget_PopupWindow", "I", AccessFlags = 25)]
						public const int Widget_PopupWindow = 16973878;
						/// <java-name>
						/// Widget_ProgressBar
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar = 16973852;
						/// <java-name>
						/// Widget_ProgressBar_Horizontal
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar_Horizontal", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar_Horizontal = 16973855;
						/// <java-name>
						/// Widget_ProgressBar_Inverse
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar_Inverse", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar_Inverse = 16973915;
						/// <java-name>
						/// Widget_ProgressBar_Large
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar_Large", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar_Large = 16973853;
						/// <java-name>
						/// Widget_ProgressBar_Large_Inverse
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar_Large_Inverse", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar_Large_Inverse = 16973916;
						/// <java-name>
						/// Widget_ProgressBar_Small
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar_Small", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar_Small = 16973854;
						/// <java-name>
						/// Widget_ProgressBar_Small_Inverse
						/// </java-name>
						[Dot42.DexImport("Widget_ProgressBar_Small_Inverse", "I", AccessFlags = 25)]
						public const int Widget_ProgressBar_Small_Inverse = 16973917;
						/// <java-name>
						/// Widget_RatingBar
						/// </java-name>
						[Dot42.DexImport("Widget_RatingBar", "I", AccessFlags = 25)]
						public const int Widget_RatingBar = 16973857;
						/// <java-name>
						/// Widget_ScrollView
						/// </java-name>
						[Dot42.DexImport("Widget_ScrollView", "I", AccessFlags = 25)]
						public const int Widget_ScrollView = 16973869;
						/// <java-name>
						/// Widget_SeekBar
						/// </java-name>
						[Dot42.DexImport("Widget_SeekBar", "I", AccessFlags = 25)]
						public const int Widget_SeekBar = 16973856;
						/// <java-name>
						/// Widget_Spinner
						/// </java-name>
						[Dot42.DexImport("Widget_Spinner", "I", AccessFlags = 25)]
						public const int Widget_Spinner = 16973864;
						/// <java-name>
						/// Widget_TabWidget
						/// </java-name>
						[Dot42.DexImport("Widget_TabWidget", "I", AccessFlags = 25)]
						public const int Widget_TabWidget = 16973876;
						/// <java-name>
						/// Widget_TextView
						/// </java-name>
						[Dot42.DexImport("Widget_TextView", "I", AccessFlags = 25)]
						public const int Widget_TextView = 16973858;
						/// <java-name>
						/// Widget_TextView_PopupMenu
						/// </java-name>
						[Dot42.DexImport("Widget_TextView_PopupMenu", "I", AccessFlags = 25)]
						public const int Widget_TextView_PopupMenu = 16973865;
						/// <java-name>
						/// Widget_TextView_SpinnerItem
						/// </java-name>
						[Dot42.DexImport("Widget_TextView_SpinnerItem", "I", AccessFlags = 25)]
						public const int Widget_TextView_SpinnerItem = 16973866;
						/// <java-name>
						/// Widget_WebView
						/// </java-name>
						[Dot42.DexImport("Widget_WebView", "I", AccessFlags = 25)]
						public const int Widget_WebView = 16973875;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Style() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$string
				/// </java-name>
				[Dot42.DexImport("android/R$string", AccessFlags = 25)]
				public sealed partial class String
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// VideoView_error_button
						/// </java-name>
						[Dot42.DexImport("VideoView_error_button", "I", AccessFlags = 25)]
						public const int VideoView_error_button = 17039376;
						/// <java-name>
						/// VideoView_error_text_invalid_progressive_playback
						/// </java-name>
						[Dot42.DexImport("VideoView_error_text_invalid_progressive_playback", "I", AccessFlags = 25)]
						public const int VideoView_error_text_invalid_progressive_playback = 17039381;
						/// <java-name>
						/// VideoView_error_text_unknown
						/// </java-name>
						[Dot42.DexImport("VideoView_error_text_unknown", "I", AccessFlags = 25)]
						public const int VideoView_error_text_unknown = 17039377;
						/// <java-name>
						/// VideoView_error_title
						/// </java-name>
						[Dot42.DexImport("VideoView_error_title", "I", AccessFlags = 25)]
						public const int VideoView_error_title = 17039378;
						/// <java-name>
						/// cancel
						/// </java-name>
						[Dot42.DexImport("cancel", "I", AccessFlags = 25)]
						public const int Cancel = 17039360;
						/// <java-name>
						/// copy
						/// </java-name>
						[Dot42.DexImport("copy", "I", AccessFlags = 25)]
						public const int Copy = 17039361;
						/// <java-name>
						/// copyUrl
						/// </java-name>
						[Dot42.DexImport("copyUrl", "I", AccessFlags = 25)]
						public const int CopyUrl = 17039362;
						/// <java-name>
						/// cut
						/// </java-name>
						[Dot42.DexImport("cut", "I", AccessFlags = 25)]
						public const int Cut = 17039363;
						/// <java-name>
						/// defaultMsisdnAlphaTag
						/// </java-name>
						[Dot42.DexImport("defaultMsisdnAlphaTag", "I", AccessFlags = 25)]
						public const int DefaultMsisdnAlphaTag = 17039365;
						/// <java-name>
						/// defaultVoiceMailAlphaTag
						/// </java-name>
						[Dot42.DexImport("defaultVoiceMailAlphaTag", "I", AccessFlags = 25)]
						public const int DefaultVoiceMailAlphaTag = 17039364;
						/// <java-name>
						/// dialog_alert_title
						/// </java-name>
						[Dot42.DexImport("dialog_alert_title", "I", AccessFlags = 25)]
						public const int Dialog_alert_title = 17039380;
						/// <java-name>
						/// emptyPhoneNumber
						/// </java-name>
						[Dot42.DexImport("emptyPhoneNumber", "I", AccessFlags = 25)]
						public const int EmptyPhoneNumber = 17039366;
						/// <java-name>
						/// httpErrorBadUrl
						/// </java-name>
						[Dot42.DexImport("httpErrorBadUrl", "I", AccessFlags = 25)]
						public const int HttpErrorBadUrl = 17039367;
						/// <java-name>
						/// httpErrorUnsupportedScheme
						/// </java-name>
						[Dot42.DexImport("httpErrorUnsupportedScheme", "I", AccessFlags = 25)]
						public const int HttpErrorUnsupportedScheme = 17039368;
						/// <java-name>
						/// no
						/// </java-name>
						[Dot42.DexImport("no", "I", AccessFlags = 25)]
						public const int No = 17039369;
						/// <java-name>
						/// ok
						/// </java-name>
						[Dot42.DexImport("ok", "I", AccessFlags = 25)]
						public const int Ok = 17039370;
						/// <java-name>
						/// paste
						/// </java-name>
						[Dot42.DexImport("paste", "I", AccessFlags = 25)]
						public const int Paste = 17039371;
						/// <java-name>
						/// search_go
						/// </java-name>
						[Dot42.DexImport("search_go", "I", AccessFlags = 25)]
						public const int Search_go = 17039372;
						/// <java-name>
						/// selectAll
						/// </java-name>
						[Dot42.DexImport("selectAll", "I", AccessFlags = 25)]
						public const int SelectAll = 17039373;
						/// <java-name>
						/// unknownName
						/// </java-name>
						[Dot42.DexImport("unknownName", "I", AccessFlags = 25)]
						public const int UnknownName = 17039374;
						/// <java-name>
						/// untitled
						/// </java-name>
						[Dot42.DexImport("untitled", "I", AccessFlags = 25)]
						public const int Untitled = 17039375;
						/// <java-name>
						/// yes
						/// </java-name>
						[Dot42.DexImport("yes", "I", AccessFlags = 25)]
						public const int Yes = 17039379;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public String() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$raw
				/// </java-name>
				[Dot42.DexImport("android/R$raw", AccessFlags = 25)]
				public sealed partial class Raw
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Raw() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$plurals
				/// </java-name>
				[Dot42.DexImport("android/R$plurals", AccessFlags = 25)]
				public sealed partial class Plurals
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Plurals() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$layout
				/// </java-name>
				[Dot42.DexImport("android/R$layout", AccessFlags = 25)]
				public sealed partial class Layout
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// activity_list_item
						/// </java-name>
						[Dot42.DexImport("activity_list_item", "I", AccessFlags = 25)]
						public const int Activity_list_item = 17367040;
						/// <java-name>
						/// browser_link_context_header
						/// </java-name>
						[Dot42.DexImport("browser_link_context_header", "I", AccessFlags = 25)]
						public const int Browser_link_context_header = 17367054;
						/// <java-name>
						/// expandable_list_content
						/// </java-name>
						[Dot42.DexImport("expandable_list_content", "I", AccessFlags = 25)]
						public const int Expandable_list_content = 17367041;
						/// <java-name>
						/// preference_category
						/// </java-name>
						[Dot42.DexImport("preference_category", "I", AccessFlags = 25)]
						public const int Preference_category = 17367042;
						/// <java-name>
						/// select_dialog_item
						/// </java-name>
						[Dot42.DexImport("select_dialog_item", "I", AccessFlags = 25)]
						public const int Select_dialog_item = 17367057;
						/// <java-name>
						/// select_dialog_multichoice
						/// </java-name>
						[Dot42.DexImport("select_dialog_multichoice", "I", AccessFlags = 25)]
						public const int Select_dialog_multichoice = 17367059;
						/// <java-name>
						/// select_dialog_singlechoice
						/// </java-name>
						[Dot42.DexImport("select_dialog_singlechoice", "I", AccessFlags = 25)]
						public const int Select_dialog_singlechoice = 17367058;
						/// <java-name>
						/// simple_dropdown_item_1line
						/// </java-name>
						[Dot42.DexImport("simple_dropdown_item_1line", "I", AccessFlags = 25)]
						public const int Simple_dropdown_item_1line = 17367050;
						/// <java-name>
						/// simple_expandable_list_item_1
						/// </java-name>
						[Dot42.DexImport("simple_expandable_list_item_1", "I", AccessFlags = 25)]
						public const int Simple_expandable_list_item_1 = 17367046;
						/// <java-name>
						/// simple_expandable_list_item_2
						/// </java-name>
						[Dot42.DexImport("simple_expandable_list_item_2", "I", AccessFlags = 25)]
						public const int Simple_expandable_list_item_2 = 17367047;
						/// <java-name>
						/// simple_gallery_item
						/// </java-name>
						[Dot42.DexImport("simple_gallery_item", "I", AccessFlags = 25)]
						public const int Simple_gallery_item = 17367051;
						/// <java-name>
						/// simple_list_item_1
						/// </java-name>
						[Dot42.DexImport("simple_list_item_1", "I", AccessFlags = 25)]
						public const int Simple_list_item_1 = 17367043;
						/// <java-name>
						/// simple_list_item_2
						/// </java-name>
						[Dot42.DexImport("simple_list_item_2", "I", AccessFlags = 25)]
						public const int Simple_list_item_2 = 17367044;
						/// <java-name>
						/// simple_list_item_checked
						/// </java-name>
						[Dot42.DexImport("simple_list_item_checked", "I", AccessFlags = 25)]
						public const int Simple_list_item_checked = 17367045;
						/// <java-name>
						/// simple_list_item_multiple_choice
						/// </java-name>
						[Dot42.DexImport("simple_list_item_multiple_choice", "I", AccessFlags = 25)]
						public const int Simple_list_item_multiple_choice = 17367056;
						/// <java-name>
						/// simple_list_item_single_choice
						/// </java-name>
						[Dot42.DexImport("simple_list_item_single_choice", "I", AccessFlags = 25)]
						public const int Simple_list_item_single_choice = 17367055;
						/// <java-name>
						/// simple_spinner_dropdown_item
						/// </java-name>
						[Dot42.DexImport("simple_spinner_dropdown_item", "I", AccessFlags = 25)]
						public const int Simple_spinner_dropdown_item = 17367049;
						/// <java-name>
						/// simple_spinner_item
						/// </java-name>
						[Dot42.DexImport("simple_spinner_item", "I", AccessFlags = 25)]
						public const int Simple_spinner_item = 17367048;
						/// <java-name>
						/// test_list_item
						/// </java-name>
						[Dot42.DexImport("test_list_item", "I", AccessFlags = 25)]
						public const int Test_list_item = 17367052;
						/// <java-name>
						/// two_line_list_item
						/// </java-name>
						[Dot42.DexImport("two_line_list_item", "I", AccessFlags = 25)]
						public const int Two_line_list_item = 17367053;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Layout() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$integer
				/// </java-name>
				[Dot42.DexImport("android/R$integer", AccessFlags = 25)]
				public sealed partial class Integer
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// config_longAnimTime
						/// </java-name>
						[Dot42.DexImport("config_longAnimTime", "I", AccessFlags = 25)]
						public const int Config_longAnimTime = 17694722;
						/// <java-name>
						/// config_mediumAnimTime
						/// </java-name>
						[Dot42.DexImport("config_mediumAnimTime", "I", AccessFlags = 25)]
						public const int Config_mediumAnimTime = 17694721;
						/// <java-name>
						/// config_shortAnimTime
						/// </java-name>
						[Dot42.DexImport("config_shortAnimTime", "I", AccessFlags = 25)]
						public const int Config_shortAnimTime = 17694720;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Integer() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$id
				/// </java-name>
				[Dot42.DexImport("android/R$id", AccessFlags = 25)]
				public sealed partial class Id
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// addToDictionary
						/// </java-name>
						[Dot42.DexImport("addToDictionary", "I", AccessFlags = 25)]
						public const int AddToDictionary = 16908330;
						/// <java-name>
						/// background
						/// </java-name>
						[Dot42.DexImport("background", "I", AccessFlags = 25)]
						public const int Background = 16908288;
						/// <java-name>
						/// button1
						/// </java-name>
						[Dot42.DexImport("button1", "I", AccessFlags = 25)]
						public const int Button1 = 16908313;
						/// <java-name>
						/// button2
						/// </java-name>
						[Dot42.DexImport("button2", "I", AccessFlags = 25)]
						public const int Button2 = 16908314;
						/// <java-name>
						/// button3
						/// </java-name>
						[Dot42.DexImport("button3", "I", AccessFlags = 25)]
						public const int Button3 = 16908315;
						/// <java-name>
						/// candidatesArea
						/// </java-name>
						[Dot42.DexImport("candidatesArea", "I", AccessFlags = 25)]
						public const int CandidatesArea = 16908317;
						/// <java-name>
						/// checkbox
						/// </java-name>
						[Dot42.DexImport("checkbox", "I", AccessFlags = 25)]
						public const int Checkbox = 16908289;
						/// <java-name>
						/// closeButton
						/// </java-name>
						[Dot42.DexImport("closeButton", "I", AccessFlags = 25)]
						public const int CloseButton = 16908327;
						/// <java-name>
						/// content
						/// </java-name>
						[Dot42.DexImport("content", "I", AccessFlags = 25)]
						public const int Content = 16908290;
						/// <java-name>
						/// copy
						/// </java-name>
						[Dot42.DexImport("copy", "I", AccessFlags = 25)]
						public const int Copy = 16908321;
						/// <java-name>
						/// copyUrl
						/// </java-name>
						[Dot42.DexImport("copyUrl", "I", AccessFlags = 25)]
						public const int CopyUrl = 16908323;
						/// <java-name>
						/// cut
						/// </java-name>
						[Dot42.DexImport("cut", "I", AccessFlags = 25)]
						public const int Cut = 16908320;
						/// <java-name>
						/// edit
						/// </java-name>
						[Dot42.DexImport("edit", "I", AccessFlags = 25)]
						public const int Edit = 16908291;
						/// <java-name>
						/// empty
						/// </java-name>
						[Dot42.DexImport("empty", "I", AccessFlags = 25)]
						public const int Empty = 16908292;
						/// <java-name>
						/// extractArea
						/// </java-name>
						[Dot42.DexImport("extractArea", "I", AccessFlags = 25)]
						public const int ExtractArea = 16908316;
						/// <java-name>
						/// hint
						/// </java-name>
						[Dot42.DexImport("hint", "I", AccessFlags = 25)]
						public const int Hint = 16908293;
						/// <java-name>
						/// icon
						/// </java-name>
						[Dot42.DexImport("icon", "I", AccessFlags = 25)]
						public const int Icon = 16908294;
						/// <java-name>
						/// icon1
						/// </java-name>
						[Dot42.DexImport("icon1", "I", AccessFlags = 25)]
						public const int Icon1 = 16908295;
						/// <java-name>
						/// icon2
						/// </java-name>
						[Dot42.DexImport("icon2", "I", AccessFlags = 25)]
						public const int Icon2 = 16908296;
						/// <java-name>
						/// input
						/// </java-name>
						[Dot42.DexImport("input", "I", AccessFlags = 25)]
						public const int Input = 16908297;
						/// <java-name>
						/// inputArea
						/// </java-name>
						[Dot42.DexImport("inputArea", "I", AccessFlags = 25)]
						public const int InputArea = 16908318;
						/// <java-name>
						/// inputExtractEditText
						/// </java-name>
						[Dot42.DexImport("inputExtractEditText", "I", AccessFlags = 25)]
						public const int InputExtractEditText = 16908325;
						/// <java-name>
						/// keyboardView
						/// </java-name>
						[Dot42.DexImport("keyboardView", "I", AccessFlags = 25)]
						public const int KeyboardView = 16908326;
						/// <java-name>
						/// list
						/// </java-name>
						[Dot42.DexImport("list", "I", AccessFlags = 25)]
						public const int List = 16908298;
						/// <java-name>
						/// message
						/// </java-name>
						[Dot42.DexImport("message", "I", AccessFlags = 25)]
						public const int Message = 16908299;
						/// <java-name>
						/// paste
						/// </java-name>
						[Dot42.DexImport("paste", "I", AccessFlags = 25)]
						public const int Paste = 16908322;
						/// <java-name>
						/// primary
						/// </java-name>
						[Dot42.DexImport("primary", "I", AccessFlags = 25)]
						public const int Primary = 16908300;
						/// <java-name>
						/// progress
						/// </java-name>
						[Dot42.DexImport("progress", "I", AccessFlags = 25)]
						public const int Progress = 16908301;
						/// <java-name>
						/// secondaryProgress
						/// </java-name>
						[Dot42.DexImport("secondaryProgress", "I", AccessFlags = 25)]
						public const int SecondaryProgress = 16908303;
						/// <java-name>
						/// selectAll
						/// </java-name>
						[Dot42.DexImport("selectAll", "I", AccessFlags = 25)]
						public const int SelectAll = 16908319;
						/// <java-name>
						/// selectedIcon
						/// </java-name>
						[Dot42.DexImport("selectedIcon", "I", AccessFlags = 25)]
						public const int SelectedIcon = 16908302;
						/// <java-name>
						/// startSelectingText
						/// </java-name>
						[Dot42.DexImport("startSelectingText", "I", AccessFlags = 25)]
						public const int StartSelectingText = 16908328;
						/// <java-name>
						/// stopSelectingText
						/// </java-name>
						[Dot42.DexImport("stopSelectingText", "I", AccessFlags = 25)]
						public const int StopSelectingText = 16908329;
						/// <java-name>
						/// summary
						/// </java-name>
						[Dot42.DexImport("summary", "I", AccessFlags = 25)]
						public const int Summary = 16908304;
						/// <java-name>
						/// switchInputMethod
						/// </java-name>
						[Dot42.DexImport("switchInputMethod", "I", AccessFlags = 25)]
						public const int SwitchInputMethod = 16908324;
						/// <java-name>
						/// tabcontent
						/// </java-name>
						[Dot42.DexImport("tabcontent", "I", AccessFlags = 25)]
						public const int Tabcontent = 16908305;
						/// <java-name>
						/// tabhost
						/// </java-name>
						[Dot42.DexImport("tabhost", "I", AccessFlags = 25)]
						public const int Tabhost = 16908306;
						/// <java-name>
						/// tabs
						/// </java-name>
						[Dot42.DexImport("tabs", "I", AccessFlags = 25)]
						public const int Tabs = 16908307;
						/// <java-name>
						/// text1
						/// </java-name>
						[Dot42.DexImport("text1", "I", AccessFlags = 25)]
						public const int Text1 = 16908308;
						/// <java-name>
						/// text2
						/// </java-name>
						[Dot42.DexImport("text2", "I", AccessFlags = 25)]
						public const int Text2 = 16908309;
						/// <java-name>
						/// title
						/// </java-name>
						[Dot42.DexImport("title", "I", AccessFlags = 25)]
						public const int Title = 16908310;
						/// <java-name>
						/// toggle
						/// </java-name>
						[Dot42.DexImport("toggle", "I", AccessFlags = 25)]
						public const int Toggle = 16908311;
						/// <java-name>
						/// widget_frame
						/// </java-name>
						[Dot42.DexImport("widget_frame", "I", AccessFlags = 25)]
						public const int Widget_frame = 16908312;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Id() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$drawable
				/// </java-name>
				[Dot42.DexImport("android/R$drawable", AccessFlags = 25)]
				public sealed partial class Drawable
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// alert_dark_frame
						/// </java-name>
						[Dot42.DexImport("alert_dark_frame", "I", AccessFlags = 25)]
						public const int Alert_dark_frame = 17301504;
						/// <java-name>
						/// alert_light_frame
						/// </java-name>
						[Dot42.DexImport("alert_light_frame", "I", AccessFlags = 25)]
						public const int Alert_light_frame = 17301505;
						/// <java-name>
						/// arrow_down_float
						/// </java-name>
						[Dot42.DexImport("arrow_down_float", "I", AccessFlags = 25)]
						public const int Arrow_down_float = 17301506;
						/// <java-name>
						/// arrow_up_float
						/// </java-name>
						[Dot42.DexImport("arrow_up_float", "I", AccessFlags = 25)]
						public const int Arrow_up_float = 17301507;
						/// <java-name>
						/// bottom_bar
						/// </java-name>
						[Dot42.DexImport("bottom_bar", "I", AccessFlags = 25)]
						public const int Bottom_bar = 17301658;
						/// <java-name>
						/// btn_default
						/// </java-name>
						[Dot42.DexImport("btn_default", "I", AccessFlags = 25)]
						public const int Btn_default = 17301508;
						/// <java-name>
						/// btn_default_small
						/// </java-name>
						[Dot42.DexImport("btn_default_small", "I", AccessFlags = 25)]
						public const int Btn_default_small = 17301509;
						/// <java-name>
						/// btn_dialog
						/// </java-name>
						[Dot42.DexImport("btn_dialog", "I", AccessFlags = 25)]
						public const int Btn_dialog = 17301527;
						/// <java-name>
						/// btn_dropdown
						/// </java-name>
						[Dot42.DexImport("btn_dropdown", "I", AccessFlags = 25)]
						public const int Btn_dropdown = 17301510;
						/// <java-name>
						/// btn_minus
						/// </java-name>
						[Dot42.DexImport("btn_minus", "I", AccessFlags = 25)]
						public const int Btn_minus = 17301511;
						/// <java-name>
						/// btn_plus
						/// </java-name>
						[Dot42.DexImport("btn_plus", "I", AccessFlags = 25)]
						public const int Btn_plus = 17301512;
						/// <java-name>
						/// btn_radio
						/// </java-name>
						[Dot42.DexImport("btn_radio", "I", AccessFlags = 25)]
						public const int Btn_radio = 17301513;
						/// <java-name>
						/// btn_star
						/// </java-name>
						[Dot42.DexImport("btn_star", "I", AccessFlags = 25)]
						public const int Btn_star = 17301514;
						/// <java-name>
						/// btn_star_big_off
						/// </java-name>
						[Dot42.DexImport("btn_star_big_off", "I", AccessFlags = 25)]
						public const int Btn_star_big_off = 17301515;
						/// <java-name>
						/// btn_star_big_on
						/// </java-name>
						[Dot42.DexImport("btn_star_big_on", "I", AccessFlags = 25)]
						public const int Btn_star_big_on = 17301516;
						/// <java-name>
						/// button_onoff_indicator_off
						/// </java-name>
						[Dot42.DexImport("button_onoff_indicator_off", "I", AccessFlags = 25)]
						public const int Button_onoff_indicator_off = 17301518;
						/// <java-name>
						/// button_onoff_indicator_on
						/// </java-name>
						[Dot42.DexImport("button_onoff_indicator_on", "I", AccessFlags = 25)]
						public const int Button_onoff_indicator_on = 17301517;
						/// <java-name>
						/// checkbox_off_background
						/// </java-name>
						[Dot42.DexImport("checkbox_off_background", "I", AccessFlags = 25)]
						public const int Checkbox_off_background = 17301519;
						/// <java-name>
						/// checkbox_on_background
						/// </java-name>
						[Dot42.DexImport("checkbox_on_background", "I", AccessFlags = 25)]
						public const int Checkbox_on_background = 17301520;
						/// <java-name>
						/// dark_header
						/// </java-name>
						[Dot42.DexImport("dark_header", "I", AccessFlags = 25)]
						public const int Dark_header = 17301669;
						/// <java-name>
						/// dialog_frame
						/// </java-name>
						[Dot42.DexImport("dialog_frame", "I", AccessFlags = 25)]
						public const int Dialog_frame = 17301521;
						/// <java-name>
						/// divider_horizontal_bright
						/// </java-name>
						[Dot42.DexImport("divider_horizontal_bright", "I", AccessFlags = 25)]
						public const int Divider_horizontal_bright = 17301522;
						/// <java-name>
						/// divider_horizontal_dark
						/// </java-name>
						[Dot42.DexImport("divider_horizontal_dark", "I", AccessFlags = 25)]
						public const int Divider_horizontal_dark = 17301524;
						/// <java-name>
						/// divider_horizontal_dim_dark
						/// </java-name>
						[Dot42.DexImport("divider_horizontal_dim_dark", "I", AccessFlags = 25)]
						public const int Divider_horizontal_dim_dark = 17301525;
						/// <java-name>
						/// divider_horizontal_textfield
						/// </java-name>
						[Dot42.DexImport("divider_horizontal_textfield", "I", AccessFlags = 25)]
						public const int Divider_horizontal_textfield = 17301523;
						/// <java-name>
						/// edit_text
						/// </java-name>
						[Dot42.DexImport("edit_text", "I", AccessFlags = 25)]
						public const int Edit_text = 17301526;
						/// <java-name>
						/// editbox_background
						/// </java-name>
						[Dot42.DexImport("editbox_background", "I", AccessFlags = 25)]
						public const int Editbox_background = 17301528;
						/// <java-name>
						/// editbox_background_normal
						/// </java-name>
						[Dot42.DexImport("editbox_background_normal", "I", AccessFlags = 25)]
						public const int Editbox_background_normal = 17301529;
						/// <java-name>
						/// editbox_dropdown_dark_frame
						/// </java-name>
						[Dot42.DexImport("editbox_dropdown_dark_frame", "I", AccessFlags = 25)]
						public const int Editbox_dropdown_dark_frame = 17301530;
						/// <java-name>
						/// editbox_dropdown_light_frame
						/// </java-name>
						[Dot42.DexImport("editbox_dropdown_light_frame", "I", AccessFlags = 25)]
						public const int Editbox_dropdown_light_frame = 17301531;
						/// <java-name>
						/// gallery_thumb
						/// </java-name>
						[Dot42.DexImport("gallery_thumb", "I", AccessFlags = 25)]
						public const int Gallery_thumb = 17301532;
						/// <java-name>
						/// ic_btn_speak_now
						/// </java-name>
						[Dot42.DexImport("ic_btn_speak_now", "I", AccessFlags = 25)]
						public const int Ic_btn_speak_now = 17301668;
						/// <java-name>
						/// ic_delete
						/// </java-name>
						[Dot42.DexImport("ic_delete", "I", AccessFlags = 25)]
						public const int Ic_delete = 17301533;
						/// <java-name>
						/// ic_dialog_alert
						/// </java-name>
						[Dot42.DexImport("ic_dialog_alert", "I", AccessFlags = 25)]
						public const int Ic_dialog_alert = 17301543;
						/// <java-name>
						/// ic_dialog_dialer
						/// </java-name>
						[Dot42.DexImport("ic_dialog_dialer", "I", AccessFlags = 25)]
						public const int Ic_dialog_dialer = 17301544;
						/// <java-name>
						/// ic_dialog_email
						/// </java-name>
						[Dot42.DexImport("ic_dialog_email", "I", AccessFlags = 25)]
						public const int Ic_dialog_email = 17301545;
						/// <java-name>
						/// ic_dialog_info
						/// </java-name>
						[Dot42.DexImport("ic_dialog_info", "I", AccessFlags = 25)]
						public const int Ic_dialog_info = 17301659;
						/// <java-name>
						/// ic_dialog_map
						/// </java-name>
						[Dot42.DexImport("ic_dialog_map", "I", AccessFlags = 25)]
						public const int Ic_dialog_map = 17301546;
						/// <java-name>
						/// ic_input_add
						/// </java-name>
						[Dot42.DexImport("ic_input_add", "I", AccessFlags = 25)]
						public const int Ic_input_add = 17301547;
						/// <java-name>
						/// ic_input_delete
						/// </java-name>
						[Dot42.DexImport("ic_input_delete", "I", AccessFlags = 25)]
						public const int Ic_input_delete = 17301548;
						/// <java-name>
						/// ic_input_get
						/// </java-name>
						[Dot42.DexImport("ic_input_get", "I", AccessFlags = 25)]
						public const int Ic_input_get = 17301549;
						/// <java-name>
						/// ic_lock_idle_alarm
						/// </java-name>
						[Dot42.DexImport("ic_lock_idle_alarm", "I", AccessFlags = 25)]
						public const int Ic_lock_idle_alarm = 17301550;
						/// <java-name>
						/// ic_lock_idle_charging
						/// </java-name>
						[Dot42.DexImport("ic_lock_idle_charging", "I", AccessFlags = 25)]
						public const int Ic_lock_idle_charging = 17301534;
						/// <java-name>
						/// ic_lock_idle_lock
						/// </java-name>
						[Dot42.DexImport("ic_lock_idle_lock", "I", AccessFlags = 25)]
						public const int Ic_lock_idle_lock = 17301535;
						/// <java-name>
						/// ic_lock_idle_low_battery
						/// </java-name>
						[Dot42.DexImport("ic_lock_idle_low_battery", "I", AccessFlags = 25)]
						public const int Ic_lock_idle_low_battery = 17301536;
						/// <java-name>
						/// ic_lock_lock
						/// </java-name>
						[Dot42.DexImport("ic_lock_lock", "I", AccessFlags = 25)]
						public const int Ic_lock_lock = 17301551;
						/// <java-name>
						/// ic_lock_power_off
						/// </java-name>
						[Dot42.DexImport("ic_lock_power_off", "I", AccessFlags = 25)]
						public const int Ic_lock_power_off = 17301552;
						/// <java-name>
						/// ic_lock_silent_mode
						/// </java-name>
						[Dot42.DexImport("ic_lock_silent_mode", "I", AccessFlags = 25)]
						public const int Ic_lock_silent_mode = 17301553;
						/// <java-name>
						/// ic_lock_silent_mode_off
						/// </java-name>
						[Dot42.DexImport("ic_lock_silent_mode_off", "I", AccessFlags = 25)]
						public const int Ic_lock_silent_mode_off = 17301554;
						/// <java-name>
						/// ic_media_ff
						/// </java-name>
						[Dot42.DexImport("ic_media_ff", "I", AccessFlags = 25)]
						public const int Ic_media_ff = 17301537;
						/// <java-name>
						/// ic_media_next
						/// </java-name>
						[Dot42.DexImport("ic_media_next", "I", AccessFlags = 25)]
						public const int Ic_media_next = 17301538;
						/// <java-name>
						/// ic_media_pause
						/// </java-name>
						[Dot42.DexImport("ic_media_pause", "I", AccessFlags = 25)]
						public const int Ic_media_pause = 17301539;
						/// <java-name>
						/// ic_media_play
						/// </java-name>
						[Dot42.DexImport("ic_media_play", "I", AccessFlags = 25)]
						public const int Ic_media_play = 17301540;
						/// <java-name>
						/// ic_media_previous
						/// </java-name>
						[Dot42.DexImport("ic_media_previous", "I", AccessFlags = 25)]
						public const int Ic_media_previous = 17301541;
						/// <java-name>
						/// ic_media_rew
						/// </java-name>
						[Dot42.DexImport("ic_media_rew", "I", AccessFlags = 25)]
						public const int Ic_media_rew = 17301542;
						/// <java-name>
						/// ic_menu_add
						/// </java-name>
						[Dot42.DexImport("ic_menu_add", "I", AccessFlags = 25)]
						public const int Ic_menu_add = 17301555;
						/// <java-name>
						/// ic_menu_agenda
						/// </java-name>
						[Dot42.DexImport("ic_menu_agenda", "I", AccessFlags = 25)]
						public const int Ic_menu_agenda = 17301556;
						/// <java-name>
						/// ic_menu_always_landscape_portrait
						/// </java-name>
						[Dot42.DexImport("ic_menu_always_landscape_portrait", "I", AccessFlags = 25)]
						public const int Ic_menu_always_landscape_portrait = 17301557;
						/// <java-name>
						/// ic_menu_call
						/// </java-name>
						[Dot42.DexImport("ic_menu_call", "I", AccessFlags = 25)]
						public const int Ic_menu_call = 17301558;
						/// <java-name>
						/// ic_menu_camera
						/// </java-name>
						[Dot42.DexImport("ic_menu_camera", "I", AccessFlags = 25)]
						public const int Ic_menu_camera = 17301559;
						/// <java-name>
						/// ic_menu_close_clear_cancel
						/// </java-name>
						[Dot42.DexImport("ic_menu_close_clear_cancel", "I", AccessFlags = 25)]
						public const int Ic_menu_close_clear_cancel = 17301560;
						/// <java-name>
						/// ic_menu_compass
						/// </java-name>
						[Dot42.DexImport("ic_menu_compass", "I", AccessFlags = 25)]
						public const int Ic_menu_compass = 17301561;
						/// <java-name>
						/// ic_menu_crop
						/// </java-name>
						[Dot42.DexImport("ic_menu_crop", "I", AccessFlags = 25)]
						public const int Ic_menu_crop = 17301562;
						/// <java-name>
						/// ic_menu_day
						/// </java-name>
						[Dot42.DexImport("ic_menu_day", "I", AccessFlags = 25)]
						public const int Ic_menu_day = 17301563;
						/// <java-name>
						/// ic_menu_delete
						/// </java-name>
						[Dot42.DexImport("ic_menu_delete", "I", AccessFlags = 25)]
						public const int Ic_menu_delete = 17301564;
						/// <java-name>
						/// ic_menu_directions
						/// </java-name>
						[Dot42.DexImport("ic_menu_directions", "I", AccessFlags = 25)]
						public const int Ic_menu_directions = 17301565;
						/// <java-name>
						/// ic_menu_edit
						/// </java-name>
						[Dot42.DexImport("ic_menu_edit", "I", AccessFlags = 25)]
						public const int Ic_menu_edit = 17301566;
						/// <java-name>
						/// ic_menu_gallery
						/// </java-name>
						[Dot42.DexImport("ic_menu_gallery", "I", AccessFlags = 25)]
						public const int Ic_menu_gallery = 17301567;
						/// <java-name>
						/// ic_menu_help
						/// </java-name>
						[Dot42.DexImport("ic_menu_help", "I", AccessFlags = 25)]
						public const int Ic_menu_help = 17301568;
						/// <java-name>
						/// ic_menu_info_details
						/// </java-name>
						[Dot42.DexImport("ic_menu_info_details", "I", AccessFlags = 25)]
						public const int Ic_menu_info_details = 17301569;
						/// <java-name>
						/// ic_menu_manage
						/// </java-name>
						[Dot42.DexImport("ic_menu_manage", "I", AccessFlags = 25)]
						public const int Ic_menu_manage = 17301570;
						/// <java-name>
						/// ic_menu_mapmode
						/// </java-name>
						[Dot42.DexImport("ic_menu_mapmode", "I", AccessFlags = 25)]
						public const int Ic_menu_mapmode = 17301571;
						/// <java-name>
						/// ic_menu_month
						/// </java-name>
						[Dot42.DexImport("ic_menu_month", "I", AccessFlags = 25)]
						public const int Ic_menu_month = 17301572;
						/// <java-name>
						/// ic_menu_more
						/// </java-name>
						[Dot42.DexImport("ic_menu_more", "I", AccessFlags = 25)]
						public const int Ic_menu_more = 17301573;
						/// <java-name>
						/// ic_menu_my_calendar
						/// </java-name>
						[Dot42.DexImport("ic_menu_my_calendar", "I", AccessFlags = 25)]
						public const int Ic_menu_my_calendar = 17301574;
						/// <java-name>
						/// ic_menu_mylocation
						/// </java-name>
						[Dot42.DexImport("ic_menu_mylocation", "I", AccessFlags = 25)]
						public const int Ic_menu_mylocation = 17301575;
						/// <java-name>
						/// ic_menu_myplaces
						/// </java-name>
						[Dot42.DexImport("ic_menu_myplaces", "I", AccessFlags = 25)]
						public const int Ic_menu_myplaces = 17301576;
						/// <java-name>
						/// ic_menu_preferences
						/// </java-name>
						[Dot42.DexImport("ic_menu_preferences", "I", AccessFlags = 25)]
						public const int Ic_menu_preferences = 17301577;
						/// <java-name>
						/// ic_menu_recent_history
						/// </java-name>
						[Dot42.DexImport("ic_menu_recent_history", "I", AccessFlags = 25)]
						public const int Ic_menu_recent_history = 17301578;
						/// <java-name>
						/// ic_menu_report_image
						/// </java-name>
						[Dot42.DexImport("ic_menu_report_image", "I", AccessFlags = 25)]
						public const int Ic_menu_report_image = 17301579;
						/// <java-name>
						/// ic_menu_revert
						/// </java-name>
						[Dot42.DexImport("ic_menu_revert", "I", AccessFlags = 25)]
						public const int Ic_menu_revert = 17301580;
						/// <java-name>
						/// ic_menu_rotate
						/// </java-name>
						[Dot42.DexImport("ic_menu_rotate", "I", AccessFlags = 25)]
						public const int Ic_menu_rotate = 17301581;
						/// <java-name>
						/// ic_menu_save
						/// </java-name>
						[Dot42.DexImport("ic_menu_save", "I", AccessFlags = 25)]
						public const int Ic_menu_save = 17301582;
						/// <java-name>
						/// ic_menu_search
						/// </java-name>
						[Dot42.DexImport("ic_menu_search", "I", AccessFlags = 25)]
						public const int Ic_menu_search = 17301583;
						/// <java-name>
						/// ic_menu_send
						/// </java-name>
						[Dot42.DexImport("ic_menu_send", "I", AccessFlags = 25)]
						public const int Ic_menu_send = 17301584;
						/// <java-name>
						/// ic_menu_set_as
						/// </java-name>
						[Dot42.DexImport("ic_menu_set_as", "I", AccessFlags = 25)]
						public const int Ic_menu_set_as = 17301585;
						/// <java-name>
						/// ic_menu_share
						/// </java-name>
						[Dot42.DexImport("ic_menu_share", "I", AccessFlags = 25)]
						public const int Ic_menu_share = 17301586;
						/// <java-name>
						/// ic_menu_slideshow
						/// </java-name>
						[Dot42.DexImport("ic_menu_slideshow", "I", AccessFlags = 25)]
						public const int Ic_menu_slideshow = 17301587;
						/// <java-name>
						/// ic_menu_sort_alphabetically
						/// </java-name>
						[Dot42.DexImport("ic_menu_sort_alphabetically", "I", AccessFlags = 25)]
						public const int Ic_menu_sort_alphabetically = 17301660;
						/// <java-name>
						/// ic_menu_sort_by_size
						/// </java-name>
						[Dot42.DexImport("ic_menu_sort_by_size", "I", AccessFlags = 25)]
						public const int Ic_menu_sort_by_size = 17301661;
						/// <java-name>
						/// ic_menu_today
						/// </java-name>
						[Dot42.DexImport("ic_menu_today", "I", AccessFlags = 25)]
						public const int Ic_menu_today = 17301588;
						/// <java-name>
						/// ic_menu_upload
						/// </java-name>
						[Dot42.DexImport("ic_menu_upload", "I", AccessFlags = 25)]
						public const int Ic_menu_upload = 17301589;
						/// <java-name>
						/// ic_menu_upload_you_tube
						/// </java-name>
						[Dot42.DexImport("ic_menu_upload_you_tube", "I", AccessFlags = 25)]
						public const int Ic_menu_upload_you_tube = 17301590;
						/// <java-name>
						/// ic_menu_view
						/// </java-name>
						[Dot42.DexImport("ic_menu_view", "I", AccessFlags = 25)]
						public const int Ic_menu_view = 17301591;
						/// <java-name>
						/// ic_menu_week
						/// </java-name>
						[Dot42.DexImport("ic_menu_week", "I", AccessFlags = 25)]
						public const int Ic_menu_week = 17301592;
						/// <java-name>
						/// ic_menu_zoom
						/// </java-name>
						[Dot42.DexImport("ic_menu_zoom", "I", AccessFlags = 25)]
						public const int Ic_menu_zoom = 17301593;
						/// <java-name>
						/// ic_notification_clear_all
						/// </java-name>
						[Dot42.DexImport("ic_notification_clear_all", "I", AccessFlags = 25)]
						public const int Ic_notification_clear_all = 17301594;
						/// <java-name>
						/// ic_notification_overlay
						/// </java-name>
						[Dot42.DexImport("ic_notification_overlay", "I", AccessFlags = 25)]
						public const int Ic_notification_overlay = 17301595;
						/// <java-name>
						/// ic_partial_secure
						/// </java-name>
						[Dot42.DexImport("ic_partial_secure", "I", AccessFlags = 25)]
						public const int Ic_partial_secure = 17301596;
						/// <java-name>
						/// ic_popup_disk_full
						/// </java-name>
						[Dot42.DexImport("ic_popup_disk_full", "I", AccessFlags = 25)]
						public const int Ic_popup_disk_full = 17301597;
						/// <java-name>
						/// ic_popup_reminder
						/// </java-name>
						[Dot42.DexImport("ic_popup_reminder", "I", AccessFlags = 25)]
						public const int Ic_popup_reminder = 17301598;
						/// <java-name>
						/// ic_popup_sync
						/// </java-name>
						[Dot42.DexImport("ic_popup_sync", "I", AccessFlags = 25)]
						public const int Ic_popup_sync = 17301599;
						/// <java-name>
						/// ic_search_category_default
						/// </java-name>
						[Dot42.DexImport("ic_search_category_default", "I", AccessFlags = 25)]
						public const int Ic_search_category_default = 17301600;
						/// <java-name>
						/// ic_secure
						/// </java-name>
						[Dot42.DexImport("ic_secure", "I", AccessFlags = 25)]
						public const int Ic_secure = 17301601;
						/// <java-name>
						/// list_selector_background
						/// </java-name>
						[Dot42.DexImport("list_selector_background", "I", AccessFlags = 25)]
						public const int List_selector_background = 17301602;
						/// <java-name>
						/// menu_frame
						/// </java-name>
						[Dot42.DexImport("menu_frame", "I", AccessFlags = 25)]
						public const int Menu_frame = 17301603;
						/// <java-name>
						/// menu_full_frame
						/// </java-name>
						[Dot42.DexImport("menu_full_frame", "I", AccessFlags = 25)]
						public const int Menu_full_frame = 17301604;
						/// <java-name>
						/// menuitem_background
						/// </java-name>
						[Dot42.DexImport("menuitem_background", "I", AccessFlags = 25)]
						public const int Menuitem_background = 17301605;
						/// <java-name>
						/// picture_frame
						/// </java-name>
						[Dot42.DexImport("picture_frame", "I", AccessFlags = 25)]
						public const int Picture_frame = 17301606;
						/// <java-name>
						/// presence_away
						/// </java-name>
						[Dot42.DexImport("presence_away", "I", AccessFlags = 25)]
						public const int Presence_away = 17301607;
						/// <java-name>
						/// presence_busy
						/// </java-name>
						[Dot42.DexImport("presence_busy", "I", AccessFlags = 25)]
						public const int Presence_busy = 17301608;
						/// <java-name>
						/// presence_invisible
						/// </java-name>
						[Dot42.DexImport("presence_invisible", "I", AccessFlags = 25)]
						public const int Presence_invisible = 17301609;
						/// <java-name>
						/// presence_offline
						/// </java-name>
						[Dot42.DexImport("presence_offline", "I", AccessFlags = 25)]
						public const int Presence_offline = 17301610;
						/// <java-name>
						/// presence_online
						/// </java-name>
						[Dot42.DexImport("presence_online", "I", AccessFlags = 25)]
						public const int Presence_online = 17301611;
						/// <java-name>
						/// progress_horizontal
						/// </java-name>
						[Dot42.DexImport("progress_horizontal", "I", AccessFlags = 25)]
						public const int Progress_horizontal = 17301612;
						/// <java-name>
						/// progress_indeterminate_horizontal
						/// </java-name>
						[Dot42.DexImport("progress_indeterminate_horizontal", "I", AccessFlags = 25)]
						public const int Progress_indeterminate_horizontal = 17301613;
						/// <java-name>
						/// radiobutton_off_background
						/// </java-name>
						[Dot42.DexImport("radiobutton_off_background", "I", AccessFlags = 25)]
						public const int Radiobutton_off_background = 17301614;
						/// <java-name>
						/// radiobutton_on_background
						/// </java-name>
						[Dot42.DexImport("radiobutton_on_background", "I", AccessFlags = 25)]
						public const int Radiobutton_on_background = 17301615;
						/// <java-name>
						/// screen_background_dark
						/// </java-name>
						[Dot42.DexImport("screen_background_dark", "I", AccessFlags = 25)]
						public const int Screen_background_dark = 17301656;
						/// <java-name>
						/// screen_background_dark_transparent
						/// </java-name>
						[Dot42.DexImport("screen_background_dark_transparent", "I", AccessFlags = 25)]
						public const int Screen_background_dark_transparent = 17301673;
						/// <java-name>
						/// screen_background_light
						/// </java-name>
						[Dot42.DexImport("screen_background_light", "I", AccessFlags = 25)]
						public const int Screen_background_light = 17301657;
						/// <java-name>
						/// screen_background_light_transparent
						/// </java-name>
						[Dot42.DexImport("screen_background_light_transparent", "I", AccessFlags = 25)]
						public const int Screen_background_light_transparent = 17301674;
						/// <java-name>
						/// spinner_background
						/// </java-name>
						[Dot42.DexImport("spinner_background", "I", AccessFlags = 25)]
						public const int Spinner_background = 17301616;
						/// <java-name>
						/// spinner_dropdown_background
						/// </java-name>
						[Dot42.DexImport("spinner_dropdown_background", "I", AccessFlags = 25)]
						public const int Spinner_dropdown_background = 17301617;
						/// <java-name>
						/// star_big_off
						/// </java-name>
						[Dot42.DexImport("star_big_off", "I", AccessFlags = 25)]
						public const int Star_big_off = 17301619;
						/// <java-name>
						/// star_big_on
						/// </java-name>
						[Dot42.DexImport("star_big_on", "I", AccessFlags = 25)]
						public const int Star_big_on = 17301618;
						/// <java-name>
						/// star_off
						/// </java-name>
						[Dot42.DexImport("star_off", "I", AccessFlags = 25)]
						public const int Star_off = 17301621;
						/// <java-name>
						/// star_on
						/// </java-name>
						[Dot42.DexImport("star_on", "I", AccessFlags = 25)]
						public const int Star_on = 17301620;
						/// <java-name>
						/// stat_notify_call_mute
						/// </java-name>
						[Dot42.DexImport("stat_notify_call_mute", "I", AccessFlags = 25)]
						public const int Stat_notify_call_mute = 17301622;
						/// <java-name>
						/// stat_notify_chat
						/// </java-name>
						[Dot42.DexImport("stat_notify_chat", "I", AccessFlags = 25)]
						public const int Stat_notify_chat = 17301623;
						/// <java-name>
						/// stat_notify_error
						/// </java-name>
						[Dot42.DexImport("stat_notify_error", "I", AccessFlags = 25)]
						public const int Stat_notify_error = 17301624;
						/// <java-name>
						/// stat_notify_missed_call
						/// </java-name>
						[Dot42.DexImport("stat_notify_missed_call", "I", AccessFlags = 25)]
						public const int Stat_notify_missed_call = 17301631;
						/// <java-name>
						/// stat_notify_more
						/// </java-name>
						[Dot42.DexImport("stat_notify_more", "I", AccessFlags = 25)]
						public const int Stat_notify_more = 17301625;
						/// <java-name>
						/// stat_notify_sdcard
						/// </java-name>
						[Dot42.DexImport("stat_notify_sdcard", "I", AccessFlags = 25)]
						public const int Stat_notify_sdcard = 17301626;
						/// <java-name>
						/// stat_notify_sdcard_prepare
						/// </java-name>
						[Dot42.DexImport("stat_notify_sdcard_prepare", "I", AccessFlags = 25)]
						public const int Stat_notify_sdcard_prepare = 17301675;
						/// <java-name>
						/// stat_notify_sdcard_usb
						/// </java-name>
						[Dot42.DexImport("stat_notify_sdcard_usb", "I", AccessFlags = 25)]
						public const int Stat_notify_sdcard_usb = 17301627;
						/// <java-name>
						/// stat_notify_sync
						/// </java-name>
						[Dot42.DexImport("stat_notify_sync", "I", AccessFlags = 25)]
						public const int Stat_notify_sync = 17301628;
						/// <java-name>
						/// stat_notify_sync_noanim
						/// </java-name>
						[Dot42.DexImport("stat_notify_sync_noanim", "I", AccessFlags = 25)]
						public const int Stat_notify_sync_noanim = 17301629;
						/// <java-name>
						/// stat_notify_voicemail
						/// </java-name>
						[Dot42.DexImport("stat_notify_voicemail", "I", AccessFlags = 25)]
						public const int Stat_notify_voicemail = 17301630;
						/// <java-name>
						/// stat_sys_data_bluetooth
						/// </java-name>
						[Dot42.DexImport("stat_sys_data_bluetooth", "I", AccessFlags = 25)]
						public const int Stat_sys_data_bluetooth = 17301632;
						/// <java-name>
						/// stat_sys_download
						/// </java-name>
						[Dot42.DexImport("stat_sys_download", "I", AccessFlags = 25)]
						public const int Stat_sys_download = 17301633;
						/// <java-name>
						/// stat_sys_download_done
						/// </java-name>
						[Dot42.DexImport("stat_sys_download_done", "I", AccessFlags = 25)]
						public const int Stat_sys_download_done = 17301634;
						/// <java-name>
						/// stat_sys_headset
						/// </java-name>
						[Dot42.DexImport("stat_sys_headset", "I", AccessFlags = 25)]
						public const int Stat_sys_headset = 17301635;
						/// <java-name>
						/// stat_sys_phone_call
						/// </java-name>
						[Dot42.DexImport("stat_sys_phone_call", "I", AccessFlags = 25)]
						public const int Stat_sys_phone_call = 17301636;
						/// <java-name>
						/// stat_sys_phone_call_forward
						/// </java-name>
						[Dot42.DexImport("stat_sys_phone_call_forward", "I", AccessFlags = 25)]
						public const int Stat_sys_phone_call_forward = 17301637;
						/// <java-name>
						/// stat_sys_phone_call_on_hold
						/// </java-name>
						[Dot42.DexImport("stat_sys_phone_call_on_hold", "I", AccessFlags = 25)]
						public const int Stat_sys_phone_call_on_hold = 17301638;
						/// <java-name>
						/// stat_sys_speakerphone
						/// </java-name>
						[Dot42.DexImport("stat_sys_speakerphone", "I", AccessFlags = 25)]
						public const int Stat_sys_speakerphone = 17301639;
						/// <java-name>
						/// stat_sys_upload
						/// </java-name>
						[Dot42.DexImport("stat_sys_upload", "I", AccessFlags = 25)]
						public const int Stat_sys_upload = 17301640;
						/// <java-name>
						/// stat_sys_upload_done
						/// </java-name>
						[Dot42.DexImport("stat_sys_upload_done", "I", AccessFlags = 25)]
						public const int Stat_sys_upload_done = 17301641;
						/// <java-name>
						/// stat_sys_vp_phone_call
						/// </java-name>
						[Dot42.DexImport("stat_sys_vp_phone_call", "I", AccessFlags = 25)]
						public const int Stat_sys_vp_phone_call = 17301671;
						/// <java-name>
						/// stat_sys_vp_phone_call_on_hold
						/// </java-name>
						[Dot42.DexImport("stat_sys_vp_phone_call_on_hold", "I", AccessFlags = 25)]
						public const int Stat_sys_vp_phone_call_on_hold = 17301672;
						/// <java-name>
						/// stat_sys_warning
						/// </java-name>
						[Dot42.DexImport("stat_sys_warning", "I", AccessFlags = 25)]
						public const int Stat_sys_warning = 17301642;
						/// <java-name>
						/// status_bar_item_app_background
						/// </java-name>
						[Dot42.DexImport("status_bar_item_app_background", "I", AccessFlags = 25)]
						public const int Status_bar_item_app_background = 17301643;
						/// <java-name>
						/// status_bar_item_background
						/// </java-name>
						[Dot42.DexImport("status_bar_item_background", "I", AccessFlags = 25)]
						public const int Status_bar_item_background = 17301644;
						/// <java-name>
						/// sym_action_call
						/// </java-name>
						[Dot42.DexImport("sym_action_call", "I", AccessFlags = 25)]
						public const int Sym_action_call = 17301645;
						/// <java-name>
						/// sym_action_chat
						/// </java-name>
						[Dot42.DexImport("sym_action_chat", "I", AccessFlags = 25)]
						public const int Sym_action_chat = 17301646;
						/// <java-name>
						/// sym_action_email
						/// </java-name>
						[Dot42.DexImport("sym_action_email", "I", AccessFlags = 25)]
						public const int Sym_action_email = 17301647;
						/// <java-name>
						/// sym_call_incoming
						/// </java-name>
						[Dot42.DexImport("sym_call_incoming", "I", AccessFlags = 25)]
						public const int Sym_call_incoming = 17301648;
						/// <java-name>
						/// sym_call_missed
						/// </java-name>
						[Dot42.DexImport("sym_call_missed", "I", AccessFlags = 25)]
						public const int Sym_call_missed = 17301649;
						/// <java-name>
						/// sym_call_outgoing
						/// </java-name>
						[Dot42.DexImport("sym_call_outgoing", "I", AccessFlags = 25)]
						public const int Sym_call_outgoing = 17301650;
						/// <java-name>
						/// sym_contact_card
						/// </java-name>
						[Dot42.DexImport("sym_contact_card", "I", AccessFlags = 25)]
						public const int Sym_contact_card = 17301652;
						/// <java-name>
						/// sym_def_app_icon
						/// </java-name>
						[Dot42.DexImport("sym_def_app_icon", "I", AccessFlags = 25)]
						public const int Sym_def_app_icon = 17301651;
						/// <java-name>
						/// title_bar
						/// </java-name>
						[Dot42.DexImport("title_bar", "I", AccessFlags = 25)]
						public const int Title_bar = 17301653;
						/// <java-name>
						/// title_bar_tall
						/// </java-name>
						[Dot42.DexImport("title_bar_tall", "I", AccessFlags = 25)]
						public const int Title_bar_tall = 17301670;
						/// <java-name>
						/// toast_frame
						/// </java-name>
						[Dot42.DexImport("toast_frame", "I", AccessFlags = 25)]
						public const int Toast_frame = 17301654;
						/// <java-name>
						/// zoom_plate
						/// </java-name>
						[Dot42.DexImport("zoom_plate", "I", AccessFlags = 25)]
						public const int Zoom_plate = 17301655;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Drawable() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$dimen
				/// </java-name>
				[Dot42.DexImport("android/R$dimen", AccessFlags = 25)]
				public sealed partial class Dimen
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// app_icon_size
						/// </java-name>
						[Dot42.DexImport("app_icon_size", "I", AccessFlags = 25)]
						public const int App_icon_size = 17104896;
						/// <java-name>
						/// thumbnail_height
						/// </java-name>
						[Dot42.DexImport("thumbnail_height", "I", AccessFlags = 25)]
						public const int Thumbnail_height = 17104897;
						/// <java-name>
						/// thumbnail_width
						/// </java-name>
						[Dot42.DexImport("thumbnail_width", "I", AccessFlags = 25)]
						public const int Thumbnail_width = 17104898;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Dimen() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$color
				/// </java-name>
				[Dot42.DexImport("android/R$color", AccessFlags = 25)]
				public sealed partial class Color
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// background_dark
						/// </java-name>
						[Dot42.DexImport("background_dark", "I", AccessFlags = 25)]
						public const int Background_dark = 17170446;
						/// <java-name>
						/// background_light
						/// </java-name>
						[Dot42.DexImport("background_light", "I", AccessFlags = 25)]
						public const int Background_light = 17170447;
						/// <java-name>
						/// black
						/// </java-name>
						[Dot42.DexImport("black", "I", AccessFlags = 25)]
						public const int Black = 17170444;
						/// <java-name>
						/// darker_gray
						/// </java-name>
						[Dot42.DexImport("darker_gray", "I", AccessFlags = 25)]
						public const int Darker_gray = 17170432;
						/// <java-name>
						/// primary_text_dark
						/// </java-name>
						[Dot42.DexImport("primary_text_dark", "I", AccessFlags = 25)]
						public const int Primary_text_dark = 17170433;
						/// <java-name>
						/// primary_text_dark_nodisable
						/// </java-name>
						[Dot42.DexImport("primary_text_dark_nodisable", "I", AccessFlags = 25)]
						public const int Primary_text_dark_nodisable = 17170434;
						/// <java-name>
						/// primary_text_light
						/// </java-name>
						[Dot42.DexImport("primary_text_light", "I", AccessFlags = 25)]
						public const int Primary_text_light = 17170435;
						/// <java-name>
						/// primary_text_light_nodisable
						/// </java-name>
						[Dot42.DexImport("primary_text_light_nodisable", "I", AccessFlags = 25)]
						public const int Primary_text_light_nodisable = 17170436;
						/// <java-name>
						/// secondary_text_dark
						/// </java-name>
						[Dot42.DexImport("secondary_text_dark", "I", AccessFlags = 25)]
						public const int Secondary_text_dark = 17170437;
						/// <java-name>
						/// secondary_text_dark_nodisable
						/// </java-name>
						[Dot42.DexImport("secondary_text_dark_nodisable", "I", AccessFlags = 25)]
						public const int Secondary_text_dark_nodisable = 17170438;
						/// <java-name>
						/// secondary_text_light
						/// </java-name>
						[Dot42.DexImport("secondary_text_light", "I", AccessFlags = 25)]
						public const int Secondary_text_light = 17170439;
						/// <java-name>
						/// secondary_text_light_nodisable
						/// </java-name>
						[Dot42.DexImport("secondary_text_light_nodisable", "I", AccessFlags = 25)]
						public const int Secondary_text_light_nodisable = 17170440;
						/// <java-name>
						/// tab_indicator_text
						/// </java-name>
						[Dot42.DexImport("tab_indicator_text", "I", AccessFlags = 25)]
						public const int Tab_indicator_text = 17170441;
						/// <java-name>
						/// tertiary_text_dark
						/// </java-name>
						[Dot42.DexImport("tertiary_text_dark", "I", AccessFlags = 25)]
						public const int Tertiary_text_dark = 17170448;
						/// <java-name>
						/// tertiary_text_light
						/// </java-name>
						[Dot42.DexImport("tertiary_text_light", "I", AccessFlags = 25)]
						public const int Tertiary_text_light = 17170449;
						/// <java-name>
						/// transparent
						/// </java-name>
						[Dot42.DexImport("transparent", "I", AccessFlags = 25)]
						public const int Transparent = 17170445;
						/// <java-name>
						/// white
						/// </java-name>
						[Dot42.DexImport("white", "I", AccessFlags = 25)]
						public const int White = 17170443;
						/// <java-name>
						/// widget_edittext_dark
						/// </java-name>
						[Dot42.DexImport("widget_edittext_dark", "I", AccessFlags = 25)]
						public const int Widget_edittext_dark = 17170442;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Color() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$bool
				/// </java-name>
				[Dot42.DexImport("android/R$bool", AccessFlags = 25)]
				public sealed partial class Bool
 /* scope: __dot42__ */ 
				{
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Bool() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$attr
				/// </java-name>
				[Dot42.DexImport("android/R$attr", AccessFlags = 25)]
				public sealed partial class Attr
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// absListViewStyle
						/// </java-name>
						[Dot42.DexImport("absListViewStyle", "I", AccessFlags = 25)]
						public const int AbsListViewStyle = 16842858;
						/// <java-name>
						/// accountPreferences
						/// </java-name>
						[Dot42.DexImport("accountPreferences", "I", AccessFlags = 25)]
						public const int AccountPreferences = 16843423;
						/// <java-name>
						/// accountType
						/// </java-name>
						[Dot42.DexImport("accountType", "I", AccessFlags = 25)]
						public const int AccountType = 16843407;
						/// <java-name>
						/// action
						/// </java-name>
						[Dot42.DexImport("action", "I", AccessFlags = 25)]
						public const int Action = 16842797;
						/// <java-name>
						/// activityCloseEnterAnimation
						/// </java-name>
						[Dot42.DexImport("activityCloseEnterAnimation", "I", AccessFlags = 25)]
						public const int ActivityCloseEnterAnimation = 16842938;
						/// <java-name>
						/// activityCloseExitAnimation
						/// </java-name>
						[Dot42.DexImport("activityCloseExitAnimation", "I", AccessFlags = 25)]
						public const int ActivityCloseExitAnimation = 16842939;
						/// <java-name>
						/// activityOpenEnterAnimation
						/// </java-name>
						[Dot42.DexImport("activityOpenEnterAnimation", "I", AccessFlags = 25)]
						public const int ActivityOpenEnterAnimation = 16842936;
						/// <java-name>
						/// activityOpenExitAnimation
						/// </java-name>
						[Dot42.DexImport("activityOpenExitAnimation", "I", AccessFlags = 25)]
						public const int ActivityOpenExitAnimation = 16842937;
						/// <java-name>
						/// addStatesFromChildren
						/// </java-name>
						[Dot42.DexImport("addStatesFromChildren", "I", AccessFlags = 25)]
						public const int AddStatesFromChildren = 16842992;
						/// <java-name>
						/// adjustViewBounds
						/// </java-name>
						[Dot42.DexImport("adjustViewBounds", "I", AccessFlags = 25)]
						public const int AdjustViewBounds = 16843038;
						/// <java-name>
						/// alertDialogStyle
						/// </java-name>
						[Dot42.DexImport("alertDialogStyle", "I", AccessFlags = 25)]
						public const int AlertDialogStyle = 16842845;
						/// <java-name>
						/// allowBackup
						/// </java-name>
						[Dot42.DexImport("allowBackup", "I", AccessFlags = 25)]
						public const int AllowBackup = 16843392;
						/// <java-name>
						/// allowClearUserData
						/// </java-name>
						[Dot42.DexImport("allowClearUserData", "I", AccessFlags = 25)]
						public const int AllowClearUserData = 16842757;
						/// <java-name>
						/// allowSingleTap
						/// </java-name>
						[Dot42.DexImport("allowSingleTap", "I", AccessFlags = 25)]
						public const int AllowSingleTap = 16843353;
						/// <java-name>
						/// allowTaskReparenting
						/// </java-name>
						[Dot42.DexImport("allowTaskReparenting", "I", AccessFlags = 25)]
						public const int AllowTaskReparenting = 16843268;
						/// <java-name>
						/// alphabeticShortcut
						/// </java-name>
						[Dot42.DexImport("alphabeticShortcut", "I", AccessFlags = 25)]
						public const int AlphabeticShortcut = 16843235;
						/// <java-name>
						/// alwaysDrawnWithCache
						/// </java-name>
						[Dot42.DexImport("alwaysDrawnWithCache", "I", AccessFlags = 25)]
						public const int AlwaysDrawnWithCache = 16842991;
						/// <java-name>
						/// alwaysRetainTaskState
						/// </java-name>
						[Dot42.DexImport("alwaysRetainTaskState", "I", AccessFlags = 25)]
						public const int AlwaysRetainTaskState = 16843267;
						/// <java-name>
						/// angle
						/// </java-name>
						[Dot42.DexImport("angle", "I", AccessFlags = 25)]
						public const int Angle = 16843168;
						/// <java-name>
						/// animateOnClick
						/// </java-name>
						[Dot42.DexImport("animateOnClick", "I", AccessFlags = 25)]
						public const int AnimateOnClick = 16843356;
						/// <java-name>
						/// animation
						/// </java-name>
						[Dot42.DexImport("animation", "I", AccessFlags = 25)]
						public const int Animation = 16843213;
						/// <java-name>
						/// animationCache
						/// </java-name>
						[Dot42.DexImport("animationCache", "I", AccessFlags = 25)]
						public const int AnimationCache = 16842989;
						/// <java-name>
						/// animationDuration
						/// </java-name>
						[Dot42.DexImport("animationDuration", "I", AccessFlags = 25)]
						public const int AnimationDuration = 16843026;
						/// <java-name>
						/// animationOrder
						/// </java-name>
						[Dot42.DexImport("animationOrder", "I", AccessFlags = 25)]
						public const int AnimationOrder = 16843214;
						/// <java-name>
						/// antialias
						/// </java-name>
						[Dot42.DexImport("antialias", "I", AccessFlags = 25)]
						public const int Antialias = 16843034;
						/// <java-name>
						/// anyDensity
						/// </java-name>
						[Dot42.DexImport("anyDensity", "I", AccessFlags = 25)]
						public const int AnyDensity = 16843372;
						/// <java-name>
						/// apiKey
						/// </java-name>
						[Dot42.DexImport("apiKey", "I", AccessFlags = 25)]
						public const int ApiKey = 16843281;
						/// <java-name>
						/// author
						/// </java-name>
						[Dot42.DexImport("author", "I", AccessFlags = 25)]
						public const int Author = 16843444;
						/// <java-name>
						/// authorities
						/// </java-name>
						[Dot42.DexImport("authorities", "I", AccessFlags = 25)]
						public const int Authorities = 16842776;
						/// <java-name>
						/// autoCompleteTextViewStyle
						/// </java-name>
						[Dot42.DexImport("autoCompleteTextViewStyle", "I", AccessFlags = 25)]
						public const int AutoCompleteTextViewStyle = 16842859;
						/// <java-name>
						/// autoLink
						/// </java-name>
						[Dot42.DexImport("autoLink", "I", AccessFlags = 25)]
						public const int AutoLink = 16842928;
						/// <java-name>
						/// autoStart
						/// </java-name>
						[Dot42.DexImport("autoStart", "I", AccessFlags = 25)]
						public const int AutoStart = 16843445;
						/// <java-name>
						/// autoText
						/// </java-name>
						[Dot42.DexImport("autoText", "I", AccessFlags = 25)]
						public const int AutoText = 16843114;
						/// <java-name>
						/// autoUrlDetect
						/// </java-name>
						[Dot42.DexImport("autoUrlDetect", "I", AccessFlags = 25)]
						public const int AutoUrlDetect = 16843404;
						/// <java-name>
						/// background
						/// </java-name>
						[Dot42.DexImport("background", "I", AccessFlags = 25)]
						public const int Background = 16842964;
						/// <java-name>
						/// backgroundDimAmount
						/// </java-name>
						[Dot42.DexImport("backgroundDimAmount", "I", AccessFlags = 25)]
						public const int BackgroundDimAmount = 16842802;
						/// <java-name>
						/// backgroundDimEnabled
						/// </java-name>
						[Dot42.DexImport("backgroundDimEnabled", "I", AccessFlags = 25)]
						public const int BackgroundDimEnabled = 16843295;
						/// <java-name>
						/// backupAgent
						/// </java-name>
						[Dot42.DexImport("backupAgent", "I", AccessFlags = 25)]
						public const int BackupAgent = 16843391;
						/// <java-name>
						/// baselineAlignBottom
						/// </java-name>
						[Dot42.DexImport("baselineAlignBottom", "I", AccessFlags = 25)]
						public const int BaselineAlignBottom = 16843042;
						/// <java-name>
						/// baselineAligned
						/// </java-name>
						[Dot42.DexImport("baselineAligned", "I", AccessFlags = 25)]
						public const int BaselineAligned = 16843046;
						/// <java-name>
						/// baselineAlignedChildIndex
						/// </java-name>
						[Dot42.DexImport("baselineAlignedChildIndex", "I", AccessFlags = 25)]
						public const int BaselineAlignedChildIndex = 16843047;
						/// <java-name>
						/// bottom
						/// </java-name>
						[Dot42.DexImport("bottom", "I", AccessFlags = 25)]
						public const int Bottom = 16843184;
						/// <java-name>
						/// bottomBright
						/// </java-name>
						[Dot42.DexImport("bottomBright", "I", AccessFlags = 25)]
						public const int BottomBright = 16842957;
						/// <java-name>
						/// bottomDark
						/// </java-name>
						[Dot42.DexImport("bottomDark", "I", AccessFlags = 25)]
						public const int BottomDark = 16842953;
						/// <java-name>
						/// bottomLeftRadius
						/// </java-name>
						[Dot42.DexImport("bottomLeftRadius", "I", AccessFlags = 25)]
						public const int BottomLeftRadius = 16843179;
						/// <java-name>
						/// bottomMedium
						/// </java-name>
						[Dot42.DexImport("bottomMedium", "I", AccessFlags = 25)]
						public const int BottomMedium = 16842958;
						/// <java-name>
						/// bottomOffset
						/// </java-name>
						[Dot42.DexImport("bottomOffset", "I", AccessFlags = 25)]
						public const int BottomOffset = 16843351;
						/// <java-name>
						/// bottomRightRadius
						/// </java-name>
						[Dot42.DexImport("bottomRightRadius", "I", AccessFlags = 25)]
						public const int BottomRightRadius = 16843180;
						/// <java-name>
						/// bufferType
						/// </java-name>
						[Dot42.DexImport("bufferType", "I", AccessFlags = 25)]
						public const int BufferType = 16843086;
						/// <java-name>
						/// button
						/// </java-name>
						[Dot42.DexImport("button", "I", AccessFlags = 25)]
						public const int Button = 16843015;
						/// <java-name>
						/// buttonStyle
						/// </java-name>
						[Dot42.DexImport("buttonStyle", "I", AccessFlags = 25)]
						public const int ButtonStyle = 16842824;
						/// <java-name>
						/// buttonStyleInset
						/// </java-name>
						[Dot42.DexImport("buttonStyleInset", "I", AccessFlags = 25)]
						public const int ButtonStyleInset = 16842826;
						/// <java-name>
						/// buttonStyleSmall
						/// </java-name>
						[Dot42.DexImport("buttonStyleSmall", "I", AccessFlags = 25)]
						public const int ButtonStyleSmall = 16842825;
						/// <java-name>
						/// buttonStyleToggle
						/// </java-name>
						[Dot42.DexImport("buttonStyleToggle", "I", AccessFlags = 25)]
						public const int ButtonStyleToggle = 16842827;
						/// <java-name>
						/// cacheColorHint
						/// </java-name>
						[Dot42.DexImport("cacheColorHint", "I", AccessFlags = 25)]
						public const int CacheColorHint = 16843009;
						/// <java-name>
						/// candidatesTextStyleSpans
						/// </java-name>
						[Dot42.DexImport("candidatesTextStyleSpans", "I", AccessFlags = 25)]
						public const int CandidatesTextStyleSpans = 16843312;
						/// <java-name>
						/// capitalize
						/// </java-name>
						[Dot42.DexImport("capitalize", "I", AccessFlags = 25)]
						public const int Capitalize = 16843113;
						/// <java-name>
						/// centerBright
						/// </java-name>
						[Dot42.DexImport("centerBright", "I", AccessFlags = 25)]
						public const int CenterBright = 16842956;
						/// <java-name>
						/// centerColor
						/// </java-name>
						[Dot42.DexImport("centerColor", "I", AccessFlags = 25)]
						public const int CenterColor = 16843275;
						/// <java-name>
						/// centerDark
						/// </java-name>
						[Dot42.DexImport("centerDark", "I", AccessFlags = 25)]
						public const int CenterDark = 16842952;
						/// <java-name>
						/// centerMedium
						/// </java-name>
						[Dot42.DexImport("centerMedium", "I", AccessFlags = 25)]
						public const int CenterMedium = 16842959;
						/// <java-name>
						/// centerX
						/// </java-name>
						[Dot42.DexImport("centerX", "I", AccessFlags = 25)]
						public const int CenterX = 16843170;
						/// <java-name>
						/// centerY
						/// </java-name>
						[Dot42.DexImport("centerY", "I", AccessFlags = 25)]
						public const int CenterY = 16843171;
						/// <java-name>
						/// checkBoxPreferenceStyle
						/// </java-name>
						[Dot42.DexImport("checkBoxPreferenceStyle", "I", AccessFlags = 25)]
						public const int CheckBoxPreferenceStyle = 16842895;
						/// <java-name>
						/// checkMark
						/// </java-name>
						[Dot42.DexImport("checkMark", "I", AccessFlags = 25)]
						public const int CheckMark = 16843016;
						/// <java-name>
						/// checkable
						/// </java-name>
						[Dot42.DexImport("checkable", "I", AccessFlags = 25)]
						public const int Checkable = 16843237;
						/// <java-name>
						/// checkableBehavior
						/// </java-name>
						[Dot42.DexImport("checkableBehavior", "I", AccessFlags = 25)]
						public const int CheckableBehavior = 16843232;
						/// <java-name>
						/// checkboxStyle
						/// </java-name>
						[Dot42.DexImport("checkboxStyle", "I", AccessFlags = 25)]
						public const int CheckboxStyle = 16842860;
						/// <java-name>
						/// checked
						/// </java-name>
						[Dot42.DexImport("checked", "I", AccessFlags = 25)]
						public const int Checked = 16843014;
						/// <java-name>
						/// checkedButton
						/// </java-name>
						[Dot42.DexImport("checkedButton", "I", AccessFlags = 25)]
						public const int CheckedButton = 16843080;
						/// <java-name>
						/// childDivider
						/// </java-name>
						[Dot42.DexImport("childDivider", "I", AccessFlags = 25)]
						public const int ChildDivider = 16843025;
						/// <java-name>
						/// childIndicator
						/// </java-name>
						[Dot42.DexImport("childIndicator", "I", AccessFlags = 25)]
						public const int ChildIndicator = 16843020;
						/// <java-name>
						/// childIndicatorLeft
						/// </java-name>
						[Dot42.DexImport("childIndicatorLeft", "I", AccessFlags = 25)]
						public const int ChildIndicatorLeft = 16843023;
						/// <java-name>
						/// childIndicatorRight
						/// </java-name>
						[Dot42.DexImport("childIndicatorRight", "I", AccessFlags = 25)]
						public const int ChildIndicatorRight = 16843024;
						/// <java-name>
						/// choiceMode
						/// </java-name>
						[Dot42.DexImport("choiceMode", "I", AccessFlags = 25)]
						public const int ChoiceMode = 16843051;
						/// <java-name>
						/// clearTaskOnLaunch
						/// </java-name>
						[Dot42.DexImport("clearTaskOnLaunch", "I", AccessFlags = 25)]
						public const int ClearTaskOnLaunch = 16842773;
						/// <java-name>
						/// clickable
						/// </java-name>
						[Dot42.DexImport("clickable", "I", AccessFlags = 25)]
						public const int Clickable = 16842981;
						/// <java-name>
						/// clipChildren
						/// </java-name>
						[Dot42.DexImport("clipChildren", "I", AccessFlags = 25)]
						public const int ClipChildren = 16842986;
						/// <java-name>
						/// clipOrientation
						/// </java-name>
						[Dot42.DexImport("clipOrientation", "I", AccessFlags = 25)]
						public const int ClipOrientation = 16843274;
						/// <java-name>
						/// clipToPadding
						/// </java-name>
						[Dot42.DexImport("clipToPadding", "I", AccessFlags = 25)]
						public const int ClipToPadding = 16842987;
						/// <java-name>
						/// codes
						/// </java-name>
						[Dot42.DexImport("codes", "I", AccessFlags = 25)]
						public const int Codes = 16843330;
						/// <java-name>
						/// collapseColumns
						/// </java-name>
						[Dot42.DexImport("collapseColumns", "I", AccessFlags = 25)]
						public const int CollapseColumns = 16843083;
						/// <java-name>
						/// color
						/// </java-name>
						[Dot42.DexImport("color", "I", AccessFlags = 25)]
						public const int Color = 16843173;
						/// <java-name>
						/// colorBackground
						/// </java-name>
						[Dot42.DexImport("colorBackground", "I", AccessFlags = 25)]
						public const int ColorBackground = 16842801;
						/// <java-name>
						/// colorBackgroundCacheHint
						/// </java-name>
						[Dot42.DexImport("colorBackgroundCacheHint", "I", AccessFlags = 25)]
						public const int ColorBackgroundCacheHint = 16843435;
						/// <java-name>
						/// colorForeground
						/// </java-name>
						[Dot42.DexImport("colorForeground", "I", AccessFlags = 25)]
						public const int ColorForeground = 16842800;
						/// <java-name>
						/// colorForegroundInverse
						/// </java-name>
						[Dot42.DexImport("colorForegroundInverse", "I", AccessFlags = 25)]
						public const int ColorForegroundInverse = 16843270;
						/// <java-name>
						/// columnDelay
						/// </java-name>
						[Dot42.DexImport("columnDelay", "I", AccessFlags = 25)]
						public const int ColumnDelay = 16843215;
						/// <java-name>
						/// columnWidth
						/// </java-name>
						[Dot42.DexImport("columnWidth", "I", AccessFlags = 25)]
						public const int ColumnWidth = 16843031;
						/// <java-name>
						/// completionHint
						/// </java-name>
						[Dot42.DexImport("completionHint", "I", AccessFlags = 25)]
						public const int CompletionHint = 16843122;
						/// <java-name>
						/// completionHintView
						/// </java-name>
						[Dot42.DexImport("completionHintView", "I", AccessFlags = 25)]
						public const int CompletionHintView = 16843123;
						/// <java-name>
						/// completionThreshold
						/// </java-name>
						[Dot42.DexImport("completionThreshold", "I", AccessFlags = 25)]
						public const int CompletionThreshold = 16843124;
						/// <java-name>
						/// configChanges
						/// </java-name>
						[Dot42.DexImport("configChanges", "I", AccessFlags = 25)]
						public const int ConfigChanges = 16842783;
						/// <java-name>
						/// configure
						/// </java-name>
						[Dot42.DexImport("configure", "I", AccessFlags = 25)]
						public const int Configure = 16843357;
						/// <java-name>
						/// constantSize
						/// </java-name>
						[Dot42.DexImport("constantSize", "I", AccessFlags = 25)]
						public const int ConstantSize = 16843158;
						/// <java-name>
						/// content
						/// </java-name>
						[Dot42.DexImport("content", "I", AccessFlags = 25)]
						public const int Content = 16843355;
						/// <java-name>
						/// contentAuthority
						/// </java-name>
						[Dot42.DexImport("contentAuthority", "I", AccessFlags = 25)]
						public const int ContentAuthority = 16843408;
						/// <java-name>
						/// contentDescription
						/// </java-name>
						[Dot42.DexImport("contentDescription", "I", AccessFlags = 25)]
						public const int ContentDescription = 16843379;
						/// <java-name>
						/// cropToPadding
						/// </java-name>
						[Dot42.DexImport("cropToPadding", "I", AccessFlags = 25)]
						public const int CropToPadding = 16843043;
						/// <java-name>
						/// cursorVisible
						/// </java-name>
						[Dot42.DexImport("cursorVisible", "I", AccessFlags = 25)]
						public const int CursorVisible = 16843090;
						/// <java-name>
						/// cycles
						/// </java-name>
						[Dot42.DexImport("cycles", "I", AccessFlags = 25)]
						public const int Cycles = 16843220;
						/// <java-name>
						/// dashGap
						/// </java-name>
						[Dot42.DexImport("dashGap", "I", AccessFlags = 25)]
						public const int DashGap = 16843175;
						/// <java-name>
						/// dashWidth
						/// </java-name>
						[Dot42.DexImport("dashWidth", "I", AccessFlags = 25)]
						public const int DashWidth = 16843174;
						/// <java-name>
						/// data
						/// </java-name>
						[Dot42.DexImport("data", "I", AccessFlags = 25)]
						public const int Data = 16842798;
						/// <java-name>
						/// debuggable
						/// </java-name>
						[Dot42.DexImport("debuggable", "I", AccessFlags = 25)]
						public const int Debuggable = 16842767;
						/// <java-name>
						/// defaultValue
						/// </java-name>
						[Dot42.DexImport("defaultValue", "I", AccessFlags = 25)]
						public const int DefaultValue = 16843245;
						/// <java-name>
						/// delay
						/// </java-name>
						[Dot42.DexImport("delay", "I", AccessFlags = 25)]
						public const int Delay = 16843212;
						/// <java-name>
						/// dependency
						/// </java-name>
						[Dot42.DexImport("dependency", "I", AccessFlags = 25)]
						public const int Dependency = 16843244;
						/// <java-name>
						/// descendantFocusability
						/// </java-name>
						[Dot42.DexImport("descendantFocusability", "I", AccessFlags = 25)]
						public const int DescendantFocusability = 16842993;
						/// <java-name>
						/// description
						/// </java-name>
						[Dot42.DexImport("description", "I", AccessFlags = 25)]
						public const int Description = 16842784;
						/// <java-name>
						/// detachWallpaper
						/// </java-name>
						[Dot42.DexImport("detachWallpaper", "I", AccessFlags = 25)]
						public const int DetachWallpaper = 16843430;
						/// <java-name>
						/// detailColumn
						/// </java-name>
						[Dot42.DexImport("detailColumn", "I", AccessFlags = 25)]
						public const int DetailColumn = 16843427;
						/// <java-name>
						/// detailSocialSummary
						/// </java-name>
						[Dot42.DexImport("detailSocialSummary", "I", AccessFlags = 25)]
						public const int DetailSocialSummary = 16843428;
						/// <java-name>
						/// dial
						/// </java-name>
						[Dot42.DexImport("dial", "I", AccessFlags = 25)]
						public const int Dial = 16843010;
						/// <java-name>
						/// dialogIcon
						/// </java-name>
						[Dot42.DexImport("dialogIcon", "I", AccessFlags = 25)]
						public const int DialogIcon = 16843252;
						/// <java-name>
						/// dialogLayout
						/// </java-name>
						[Dot42.DexImport("dialogLayout", "I", AccessFlags = 25)]
						public const int DialogLayout = 16843255;
						/// <java-name>
						/// dialogMessage
						/// </java-name>
						[Dot42.DexImport("dialogMessage", "I", AccessFlags = 25)]
						public const int DialogMessage = 16843251;
						/// <java-name>
						/// dialogPreferenceStyle
						/// </java-name>
						[Dot42.DexImport("dialogPreferenceStyle", "I", AccessFlags = 25)]
						public const int DialogPreferenceStyle = 16842897;
						/// <java-name>
						/// dialogTitle
						/// </java-name>
						[Dot42.DexImport("dialogTitle", "I", AccessFlags = 25)]
						public const int DialogTitle = 16843250;
						/// <java-name>
						/// digits
						/// </java-name>
						[Dot42.DexImport("digits", "I", AccessFlags = 25)]
						public const int Digits = 16843110;
						/// <java-name>
						/// direction
						/// </java-name>
						[Dot42.DexImport("direction", "I", AccessFlags = 25)]
						public const int Direction = 16843217;
						/// <java-name>
						/// directionPriority
						/// </java-name>
						[Dot42.DexImport("directionPriority", "I", AccessFlags = 25)]
						public const int DirectionPriority = 16843218;
						/// <java-name>
						/// disableDependentsState
						/// </java-name>
						[Dot42.DexImport("disableDependentsState", "I", AccessFlags = 25)]
						public const int DisableDependentsState = 16843249;
						/// <java-name>
						/// disabledAlpha
						/// </java-name>
						[Dot42.DexImport("disabledAlpha", "I", AccessFlags = 25)]
						public const int DisabledAlpha = 16842803;
						/// <java-name>
						/// dither
						/// </java-name>
						[Dot42.DexImport("dither", "I", AccessFlags = 25)]
						public const int Dither = 16843036;
						/// <java-name>
						/// divider
						/// </java-name>
						[Dot42.DexImport("divider", "I", AccessFlags = 25)]
						public const int Divider = 16843049;
						/// <java-name>
						/// dividerHeight
						/// </java-name>
						[Dot42.DexImport("dividerHeight", "I", AccessFlags = 25)]
						public const int DividerHeight = 16843050;
						/// <java-name>
						/// drawSelectorOnTop
						/// </java-name>
						[Dot42.DexImport("drawSelectorOnTop", "I", AccessFlags = 25)]
						public const int DrawSelectorOnTop = 16843004;
						/// <java-name>
						/// drawable
						/// </java-name>
						[Dot42.DexImport("drawable", "I", AccessFlags = 25)]
						public const int Drawable = 16843161;
						/// <java-name>
						/// drawableBottom
						/// </java-name>
						[Dot42.DexImport("drawableBottom", "I", AccessFlags = 25)]
						public const int DrawableBottom = 16843118;
						/// <java-name>
						/// drawableLeft
						/// </java-name>
						[Dot42.DexImport("drawableLeft", "I", AccessFlags = 25)]
						public const int DrawableLeft = 16843119;
						/// <java-name>
						/// drawablePadding
						/// </java-name>
						[Dot42.DexImport("drawablePadding", "I", AccessFlags = 25)]
						public const int DrawablePadding = 16843121;
						/// <java-name>
						/// drawableRight
						/// </java-name>
						[Dot42.DexImport("drawableRight", "I", AccessFlags = 25)]
						public const int DrawableRight = 16843120;
						/// <java-name>
						/// drawableTop
						/// </java-name>
						[Dot42.DexImport("drawableTop", "I", AccessFlags = 25)]
						public const int DrawableTop = 16843117;
						/// <java-name>
						/// drawingCacheQuality
						/// </java-name>
						[Dot42.DexImport("drawingCacheQuality", "I", AccessFlags = 25)]
						public const int DrawingCacheQuality = 16842984;
						/// <java-name>
						/// dropDownAnchor
						/// </java-name>
						[Dot42.DexImport("dropDownAnchor", "I", AccessFlags = 25)]
						public const int DropDownAnchor = 16843363;
						/// <java-name>
						/// dropDownHeight
						/// </java-name>
						[Dot42.DexImport("dropDownHeight", "I", AccessFlags = 25)]
						public const int DropDownHeight = 16843395;
						/// <java-name>
						/// dropDownHintAppearance
						/// </java-name>
						[Dot42.DexImport("dropDownHintAppearance", "I", AccessFlags = 25)]
						public const int DropDownHintAppearance = 16842888;
						/// <java-name>
						/// dropDownHorizontalOffset
						/// </java-name>
						[Dot42.DexImport("dropDownHorizontalOffset", "I", AccessFlags = 25)]
						public const int DropDownHorizontalOffset = 16843436;
						/// <java-name>
						/// dropDownItemStyle
						/// </java-name>
						[Dot42.DexImport("dropDownItemStyle", "I", AccessFlags = 25)]
						public const int DropDownItemStyle = 16842886;
						/// <java-name>
						/// dropDownListViewStyle
						/// </java-name>
						[Dot42.DexImport("dropDownListViewStyle", "I", AccessFlags = 25)]
						public const int DropDownListViewStyle = 16842861;
						/// <java-name>
						/// dropDownSelector
						/// </java-name>
						[Dot42.DexImport("dropDownSelector", "I", AccessFlags = 25)]
						public const int DropDownSelector = 16843125;
						/// <java-name>
						/// dropDownVerticalOffset
						/// </java-name>
						[Dot42.DexImport("dropDownVerticalOffset", "I", AccessFlags = 25)]
						public const int DropDownVerticalOffset = 16843437;
						/// <java-name>
						/// dropDownWidth
						/// </java-name>
						[Dot42.DexImport("dropDownWidth", "I", AccessFlags = 25)]
						public const int DropDownWidth = 16843362;
						/// <java-name>
						/// duplicateParentState
						/// </java-name>
						[Dot42.DexImport("duplicateParentState", "I", AccessFlags = 25)]
						public const int DuplicateParentState = 16842985;
						/// <java-name>
						/// duration
						/// </java-name>
						[Dot42.DexImport("duration", "I", AccessFlags = 25)]
						public const int Duration = 16843160;
						/// <java-name>
						/// editTextPreferenceStyle
						/// </java-name>
						[Dot42.DexImport("editTextPreferenceStyle", "I", AccessFlags = 25)]
						public const int EditTextPreferenceStyle = 16842898;
						/// <java-name>
						/// editTextStyle
						/// </java-name>
						[Dot42.DexImport("editTextStyle", "I", AccessFlags = 25)]
						public const int EditTextStyle = 16842862;
						/// <java-name>
						/// editable
						/// </java-name>
						[Dot42.DexImport("editable", "I", AccessFlags = 25)]
						public const int Editable = 16843115;
						/// <java-name>
						/// editorExtras
						/// </java-name>
						[Dot42.DexImport("editorExtras", "I", AccessFlags = 25)]
						public const int EditorExtras = 16843300;
						/// <java-name>
						/// ellipsize
						/// </java-name>
						[Dot42.DexImport("ellipsize", "I", AccessFlags = 25)]
						public const int Ellipsize = 16842923;
						/// <java-name>
						/// ems
						/// </java-name>
						[Dot42.DexImport("ems", "I", AccessFlags = 25)]
						public const int Ems = 16843096;
						/// <java-name>
						/// enabled
						/// </java-name>
						[Dot42.DexImport("enabled", "I", AccessFlags = 25)]
						public const int Enabled = 16842766;
						/// <java-name>
						/// endColor
						/// </java-name>
						[Dot42.DexImport("endColor", "I", AccessFlags = 25)]
						public const int EndColor = 16843166;
						/// <java-name>
						/// endYear
						/// </java-name>
						[Dot42.DexImport("endYear", "I", AccessFlags = 25)]
						public const int EndYear = 16843133;
						/// <java-name>
						/// entries
						/// </java-name>
						[Dot42.DexImport("entries", "I", AccessFlags = 25)]
						public const int Entries = 16842930;
						/// <java-name>
						/// entryValues
						/// </java-name>
						[Dot42.DexImport("entryValues", "I", AccessFlags = 25)]
						public const int EntryValues = 16843256;
						/// <java-name>
						/// eventsInterceptionEnabled
						/// </java-name>
						[Dot42.DexImport("eventsInterceptionEnabled", "I", AccessFlags = 25)]
						public const int EventsInterceptionEnabled = 16843389;
						/// <java-name>
						/// excludeFromRecents
						/// </java-name>
						[Dot42.DexImport("excludeFromRecents", "I", AccessFlags = 25)]
						public const int ExcludeFromRecents = 16842775;
						/// <java-name>
						/// expandableListPreferredChildIndicatorLeft
						/// </java-name>
						[Dot42.DexImport("expandableListPreferredChildIndicatorLeft", "I", AccessFlags = 25)]
						public const int ExpandableListPreferredChildIndicatorLeft = 16842834;
						/// <java-name>
						/// expandableListPreferredChildIndicatorRight
						/// </java-name>
						[Dot42.DexImport("expandableListPreferredChildIndicatorRight", "I", AccessFlags = 25)]
						public const int ExpandableListPreferredChildIndicatorRight = 16842835;
						/// <java-name>
						/// expandableListPreferredChildPaddingLeft
						/// </java-name>
						[Dot42.DexImport("expandableListPreferredChildPaddingLeft", "I", AccessFlags = 25)]
						public const int ExpandableListPreferredChildPaddingLeft = 16842831;
						/// <java-name>
						/// expandableListPreferredItemIndicatorLeft
						/// </java-name>
						[Dot42.DexImport("expandableListPreferredItemIndicatorLeft", "I", AccessFlags = 25)]
						public const int ExpandableListPreferredItemIndicatorLeft = 16842832;
						/// <java-name>
						/// expandableListPreferredItemIndicatorRight
						/// </java-name>
						[Dot42.DexImport("expandableListPreferredItemIndicatorRight", "I", AccessFlags = 25)]
						public const int ExpandableListPreferredItemIndicatorRight = 16842833;
						/// <java-name>
						/// expandableListPreferredItemPaddingLeft
						/// </java-name>
						[Dot42.DexImport("expandableListPreferredItemPaddingLeft", "I", AccessFlags = 25)]
						public const int ExpandableListPreferredItemPaddingLeft = 16842830;
						/// <java-name>
						/// expandableListViewStyle
						/// </java-name>
						[Dot42.DexImport("expandableListViewStyle", "I", AccessFlags = 25)]
						public const int ExpandableListViewStyle = 16842863;
						/// <java-name>
						/// exported
						/// </java-name>
						[Dot42.DexImport("exported", "I", AccessFlags = 25)]
						public const int Exported = 16842768;
						/// <java-name>
						/// extraTension
						/// </java-name>
						[Dot42.DexImport("extraTension", "I", AccessFlags = 25)]
						public const int ExtraTension = 16843371;
						/// <java-name>
						/// factor
						/// </java-name>
						[Dot42.DexImport("factor", "I", AccessFlags = 25)]
						public const int Factor = 16843219;
						/// <java-name>
						/// fadeDuration
						/// </java-name>
						[Dot42.DexImport("fadeDuration", "I", AccessFlags = 25)]
						public const int FadeDuration = 16843384;
						/// <java-name>
						/// fadeEnabled
						/// </java-name>
						[Dot42.DexImport("fadeEnabled", "I", AccessFlags = 25)]
						public const int FadeEnabled = 16843390;
						/// <java-name>
						/// fadeOffset
						/// </java-name>
						[Dot42.DexImport("fadeOffset", "I", AccessFlags = 25)]
						public const int FadeOffset = 16843383;
						/// <java-name>
						/// fadeScrollbars
						/// </java-name>
						[Dot42.DexImport("fadeScrollbars", "I", AccessFlags = 25)]
						public const int FadeScrollbars = 16843434;
						/// <java-name>
						/// fadingEdge
						/// </java-name>
						[Dot42.DexImport("fadingEdge", "I", AccessFlags = 25)]
						public const int FadingEdge = 16842975;
						/// <java-name>
						/// fadingEdgeLength
						/// </java-name>
						[Dot42.DexImport("fadingEdgeLength", "I", AccessFlags = 25)]
						public const int FadingEdgeLength = 16842976;
						/// <java-name>
						/// fastScrollEnabled
						/// </java-name>
						[Dot42.DexImport("fastScrollEnabled", "I", AccessFlags = 25)]
						public const int FastScrollEnabled = 16843302;
						/// <java-name>
						/// fillAfter
						/// </java-name>
						[Dot42.DexImport("fillAfter", "I", AccessFlags = 25)]
						public const int FillAfter = 16843197;
						/// <java-name>
						/// fillBefore
						/// </java-name>
						[Dot42.DexImport("fillBefore", "I", AccessFlags = 25)]
						public const int FillBefore = 16843196;
						/// <java-name>
						/// fillEnabled
						/// </java-name>
						[Dot42.DexImport("fillEnabled", "I", AccessFlags = 25)]
						public const int FillEnabled = 16843343;
						/// <java-name>
						/// fillViewport
						/// </java-name>
						[Dot42.DexImport("fillViewport", "I", AccessFlags = 25)]
						public const int FillViewport = 16843130;
						/// <java-name>
						/// filter
						/// </java-name>
						[Dot42.DexImport("filter", "I", AccessFlags = 25)]
						public const int Filter = 16843035;
						/// <java-name>
						/// finishOnCloseSystemDialogs
						/// </java-name>
						[Dot42.DexImport("finishOnCloseSystemDialogs", "I", AccessFlags = 25)]
						public const int FinishOnCloseSystemDialogs = 16843431;
						/// <java-name>
						/// finishOnTaskLaunch
						/// </java-name>
						[Dot42.DexImport("finishOnTaskLaunch", "I", AccessFlags = 25)]
						public const int FinishOnTaskLaunch = 16842772;
						/// <java-name>
						/// fitsSystemWindows
						/// </java-name>
						[Dot42.DexImport("fitsSystemWindows", "I", AccessFlags = 25)]
						public const int FitsSystemWindows = 16842973;
						/// <java-name>
						/// flipInterval
						/// </java-name>
						[Dot42.DexImport("flipInterval", "I", AccessFlags = 25)]
						public const int FlipInterval = 16843129;
						/// <java-name>
						/// focusable
						/// </java-name>
						[Dot42.DexImport("focusable", "I", AccessFlags = 25)]
						public const int Focusable = 16842970;
						/// <java-name>
						/// focusableInTouchMode
						/// </java-name>
						[Dot42.DexImport("focusableInTouchMode", "I", AccessFlags = 25)]
						public const int FocusableInTouchMode = 16842971;
						/// <java-name>
						/// footerDividersEnabled
						/// </java-name>
						[Dot42.DexImport("footerDividersEnabled", "I", AccessFlags = 25)]
						public const int FooterDividersEnabled = 16843311;
						/// <java-name>
						/// foreground
						/// </java-name>
						[Dot42.DexImport("foreground", "I", AccessFlags = 25)]
						public const int Foreground = 16843017;
						/// <java-name>
						/// foregroundGravity
						/// </java-name>
						[Dot42.DexImport("foregroundGravity", "I", AccessFlags = 25)]
						public const int ForegroundGravity = 16843264;
						/// <java-name>
						/// format
						/// </java-name>
						[Dot42.DexImport("format", "I", AccessFlags = 25)]
						public const int Format = 16843013;
						/// <java-name>
						/// freezesText
						/// </java-name>
						[Dot42.DexImport("freezesText", "I", AccessFlags = 25)]
						public const int FreezesText = 16843116;
						/// <java-name>
						/// fromAlpha
						/// </java-name>
						[Dot42.DexImport("fromAlpha", "I", AccessFlags = 25)]
						public const int FromAlpha = 16843210;
						/// <java-name>
						/// fromDegrees
						/// </java-name>
						[Dot42.DexImport("fromDegrees", "I", AccessFlags = 25)]
						public const int FromDegrees = 16843187;
						/// <java-name>
						/// fromXDelta
						/// </java-name>
						[Dot42.DexImport("fromXDelta", "I", AccessFlags = 25)]
						public const int FromXDelta = 16843206;
						/// <java-name>
						/// fromXScale
						/// </java-name>
						[Dot42.DexImport("fromXScale", "I", AccessFlags = 25)]
						public const int FromXScale = 16843202;
						/// <java-name>
						/// fromYDelta
						/// </java-name>
						[Dot42.DexImport("fromYDelta", "I", AccessFlags = 25)]
						public const int FromYDelta = 16843208;
						/// <java-name>
						/// fromYScale
						/// </java-name>
						[Dot42.DexImport("fromYScale", "I", AccessFlags = 25)]
						public const int FromYScale = 16843204;
						/// <java-name>
						/// fullBright
						/// </java-name>
						[Dot42.DexImport("fullBright", "I", AccessFlags = 25)]
						public const int FullBright = 16842954;
						/// <java-name>
						/// fullDark
						/// </java-name>
						[Dot42.DexImport("fullDark", "I", AccessFlags = 25)]
						public const int FullDark = 16842950;
						/// <java-name>
						/// functionalTest
						/// </java-name>
						[Dot42.DexImport("functionalTest", "I", AccessFlags = 25)]
						public const int FunctionalTest = 16842787;
						/// <java-name>
						/// galleryItemBackground
						/// </java-name>
						[Dot42.DexImport("galleryItemBackground", "I", AccessFlags = 25)]
						public const int GalleryItemBackground = 16842828;
						/// <java-name>
						/// galleryStyle
						/// </java-name>
						[Dot42.DexImport("galleryStyle", "I", AccessFlags = 25)]
						public const int GalleryStyle = 16842864;
						/// <java-name>
						/// gestureColor
						/// </java-name>
						[Dot42.DexImport("gestureColor", "I", AccessFlags = 25)]
						public const int GestureColor = 16843381;
						/// <java-name>
						/// gestureStrokeAngleThreshold
						/// </java-name>
						[Dot42.DexImport("gestureStrokeAngleThreshold", "I", AccessFlags = 25)]
						public const int GestureStrokeAngleThreshold = 16843388;
						/// <java-name>
						/// gestureStrokeLengthThreshold
						/// </java-name>
						[Dot42.DexImport("gestureStrokeLengthThreshold", "I", AccessFlags = 25)]
						public const int GestureStrokeLengthThreshold = 16843386;
						/// <java-name>
						/// gestureStrokeSquarenessThreshold
						/// </java-name>
						[Dot42.DexImport("gestureStrokeSquarenessThreshold", "I", AccessFlags = 25)]
						public const int GestureStrokeSquarenessThreshold = 16843387;
						/// <java-name>
						/// gestureStrokeType
						/// </java-name>
						[Dot42.DexImport("gestureStrokeType", "I", AccessFlags = 25)]
						public const int GestureStrokeType = 16843385;
						/// <java-name>
						/// gestureStrokeWidth
						/// </java-name>
						[Dot42.DexImport("gestureStrokeWidth", "I", AccessFlags = 25)]
						public const int GestureStrokeWidth = 16843380;
						/// <java-name>
						/// glEsVersion
						/// </java-name>
						[Dot42.DexImport("glEsVersion", "I", AccessFlags = 25)]
						public const int GlEsVersion = 16843393;
						/// <java-name>
						/// gradientRadius
						/// </java-name>
						[Dot42.DexImport("gradientRadius", "I", AccessFlags = 25)]
						public const int GradientRadius = 16843172;
						/// <java-name>
						/// grantUriPermissions
						/// </java-name>
						[Dot42.DexImport("grantUriPermissions", "I", AccessFlags = 25)]
						public const int GrantUriPermissions = 16842779;
						/// <java-name>
						/// gravity
						/// </java-name>
						[Dot42.DexImport("gravity", "I", AccessFlags = 25)]
						public const int Gravity = 16842927;
						/// <java-name>
						/// gridViewStyle
						/// </java-name>
						[Dot42.DexImport("gridViewStyle", "I", AccessFlags = 25)]
						public const int GridViewStyle = 16842865;
						/// <java-name>
						/// groupIndicator
						/// </java-name>
						[Dot42.DexImport("groupIndicator", "I", AccessFlags = 25)]
						public const int GroupIndicator = 16843019;
						/// <java-name>
						/// hand_hour
						/// </java-name>
						[Dot42.DexImport("hand_hour", "I", AccessFlags = 25)]
						public const int Hand_hour = 16843011;
						/// <java-name>
						/// hand_minute
						/// </java-name>
						[Dot42.DexImport("hand_minute", "I", AccessFlags = 25)]
						public const int Hand_minute = 16843012;
						/// <java-name>
						/// handle
						/// </java-name>
						[Dot42.DexImport("handle", "I", AccessFlags = 25)]
						public const int Handle = 16843354;
						/// <java-name>
						/// handleProfiling
						/// </java-name>
						[Dot42.DexImport("handleProfiling", "I", AccessFlags = 25)]
						public const int HandleProfiling = 16842786;
						/// <java-name>
						/// hapticFeedbackEnabled
						/// </java-name>
						[Dot42.DexImport("hapticFeedbackEnabled", "I", AccessFlags = 25)]
						public const int HapticFeedbackEnabled = 16843358;
						/// <java-name>
						/// hasCode
						/// </java-name>
						[Dot42.DexImport("hasCode", "I", AccessFlags = 25)]
						public const int HasCode = 16842764;
						/// <java-name>
						/// headerBackground
						/// </java-name>
						[Dot42.DexImport("headerBackground", "I", AccessFlags = 25)]
						public const int HeaderBackground = 16843055;
						/// <java-name>
						/// headerDividersEnabled
						/// </java-name>
						[Dot42.DexImport("headerDividersEnabled", "I", AccessFlags = 25)]
						public const int HeaderDividersEnabled = 16843310;
						/// <java-name>
						/// height
						/// </java-name>
						[Dot42.DexImport("height", "I", AccessFlags = 25)]
						public const int Height = 16843093;
						/// <java-name>
						/// hint
						/// </java-name>
						[Dot42.DexImport("hint", "I", AccessFlags = 25)]
						public const int Hint = 16843088;
						/// <java-name>
						/// horizontalDivider
						/// </java-name>
						[Dot42.DexImport("horizontalDivider", "I", AccessFlags = 25)]
						public const int HorizontalDivider = 16843053;
						/// <java-name>
						/// horizontalGap
						/// </java-name>
						[Dot42.DexImport("horizontalGap", "I", AccessFlags = 25)]
						public const int HorizontalGap = 16843327;
						/// <java-name>
						/// horizontalSpacing
						/// </java-name>
						[Dot42.DexImport("horizontalSpacing", "I", AccessFlags = 25)]
						public const int HorizontalSpacing = 16843028;
						/// <java-name>
						/// host
						/// </java-name>
						[Dot42.DexImport("host", "I", AccessFlags = 25)]
						public const int Host = 16842792;
						/// <java-name>
						/// icon
						/// </java-name>
						[Dot42.DexImport("icon", "I", AccessFlags = 25)]
						public const int Icon = 16842754;
						/// <java-name>
						/// iconPreview
						/// </java-name>
						[Dot42.DexImport("iconPreview", "I", AccessFlags = 25)]
						public const int IconPreview = 16843337;
						/// <java-name>
						/// id
						/// </java-name>
						[Dot42.DexImport("id", "I", AccessFlags = 25)]
						public const int Id = 16842960;
						/// <java-name>
						/// ignoreGravity
						/// </java-name>
						[Dot42.DexImport("ignoreGravity", "I", AccessFlags = 25)]
						public const int IgnoreGravity = 16843263;
						/// <java-name>
						/// imageButtonStyle
						/// </java-name>
						[Dot42.DexImport("imageButtonStyle", "I", AccessFlags = 25)]
						public const int ImageButtonStyle = 16842866;
						/// <java-name>
						/// imageWellStyle
						/// </java-name>
						[Dot42.DexImport("imageWellStyle", "I", AccessFlags = 25)]
						public const int ImageWellStyle = 16842867;
						/// <java-name>
						/// imeActionId
						/// </java-name>
						[Dot42.DexImport("imeActionId", "I", AccessFlags = 25)]
						public const int ImeActionId = 16843366;
						/// <java-name>
						/// imeActionLabel
						/// </java-name>
						[Dot42.DexImport("imeActionLabel", "I", AccessFlags = 25)]
						public const int ImeActionLabel = 16843365;
						/// <java-name>
						/// imeExtractEnterAnimation
						/// </java-name>
						[Dot42.DexImport("imeExtractEnterAnimation", "I", AccessFlags = 25)]
						public const int ImeExtractEnterAnimation = 16843368;
						/// <java-name>
						/// imeExtractExitAnimation
						/// </java-name>
						[Dot42.DexImport("imeExtractExitAnimation", "I", AccessFlags = 25)]
						public const int ImeExtractExitAnimation = 16843369;
						/// <java-name>
						/// imeFullscreenBackground
						/// </java-name>
						[Dot42.DexImport("imeFullscreenBackground", "I", AccessFlags = 25)]
						public const int ImeFullscreenBackground = 16843308;
						/// <java-name>
						/// imeOptions
						/// </java-name>
						[Dot42.DexImport("imeOptions", "I", AccessFlags = 25)]
						public const int ImeOptions = 16843364;
						/// <java-name>
						/// inAnimation
						/// </java-name>
						[Dot42.DexImport("inAnimation", "I", AccessFlags = 25)]
						public const int InAnimation = 16843127;
						/// <java-name>
						/// includeFontPadding
						/// </java-name>
						[Dot42.DexImport("includeFontPadding", "I", AccessFlags = 25)]
						public const int IncludeFontPadding = 16843103;
						/// <java-name>
						/// includeInGlobalSearch
						/// </java-name>
						[Dot42.DexImport("includeInGlobalSearch", "I", AccessFlags = 25)]
						public const int IncludeInGlobalSearch = 16843374;
						/// <java-name>
						/// indeterminate
						/// </java-name>
						[Dot42.DexImport("indeterminate", "I", AccessFlags = 25)]
						public const int Indeterminate = 16843065;
						/// <java-name>
						/// indeterminateBehavior
						/// </java-name>
						[Dot42.DexImport("indeterminateBehavior", "I", AccessFlags = 25)]
						public const int IndeterminateBehavior = 16843070;
						/// <java-name>
						/// indeterminateDrawable
						/// </java-name>
						[Dot42.DexImport("indeterminateDrawable", "I", AccessFlags = 25)]
						public const int IndeterminateDrawable = 16843067;
						/// <java-name>
						/// indeterminateDuration
						/// </java-name>
						[Dot42.DexImport("indeterminateDuration", "I", AccessFlags = 25)]
						public const int IndeterminateDuration = 16843069;
						/// <java-name>
						/// indeterminateOnly
						/// </java-name>
						[Dot42.DexImport("indeterminateOnly", "I", AccessFlags = 25)]
						public const int IndeterminateOnly = 16843066;
						/// <java-name>
						/// indicatorLeft
						/// </java-name>
						[Dot42.DexImport("indicatorLeft", "I", AccessFlags = 25)]
						public const int IndicatorLeft = 16843021;
						/// <java-name>
						/// indicatorRight
						/// </java-name>
						[Dot42.DexImport("indicatorRight", "I", AccessFlags = 25)]
						public const int IndicatorRight = 16843022;
						/// <java-name>
						/// inflatedId
						/// </java-name>
						[Dot42.DexImport("inflatedId", "I", AccessFlags = 25)]
						public const int InflatedId = 16842995;
						/// <java-name>
						/// initOrder
						/// </java-name>
						[Dot42.DexImport("initOrder", "I", AccessFlags = 25)]
						public const int InitOrder = 16842778;
						/// <java-name>
						/// initialLayout
						/// </java-name>
						[Dot42.DexImport("initialLayout", "I", AccessFlags = 25)]
						public const int InitialLayout = 16843345;
						/// <java-name>
						/// innerRadius
						/// </java-name>
						[Dot42.DexImport("innerRadius", "I", AccessFlags = 25)]
						public const int InnerRadius = 16843359;
						/// <java-name>
						/// innerRadiusRatio
						/// </java-name>
						[Dot42.DexImport("innerRadiusRatio", "I", AccessFlags = 25)]
						public const int InnerRadiusRatio = 16843163;
						/// <java-name>
						/// inputMethod
						/// </java-name>
						[Dot42.DexImport("inputMethod", "I", AccessFlags = 25)]
						public const int InputMethod = 16843112;
						/// <java-name>
						/// inputType
						/// </java-name>
						[Dot42.DexImport("inputType", "I", AccessFlags = 25)]
						public const int InputType = 16843296;
						/// <java-name>
						/// insetBottom
						/// </java-name>
						[Dot42.DexImport("insetBottom", "I", AccessFlags = 25)]
						public const int InsetBottom = 16843194;
						/// <java-name>
						/// insetLeft
						/// </java-name>
						[Dot42.DexImport("insetLeft", "I", AccessFlags = 25)]
						public const int InsetLeft = 16843191;
						/// <java-name>
						/// insetRight
						/// </java-name>
						[Dot42.DexImport("insetRight", "I", AccessFlags = 25)]
						public const int InsetRight = 16843192;
						/// <java-name>
						/// insetTop
						/// </java-name>
						[Dot42.DexImport("insetTop", "I", AccessFlags = 25)]
						public const int InsetTop = 16843193;
						/// <java-name>
						/// interpolator
						/// </java-name>
						[Dot42.DexImport("interpolator", "I", AccessFlags = 25)]
						public const int Interpolator = 16843073;
						/// <java-name>
						/// isDefault
						/// </java-name>
						[Dot42.DexImport("isDefault", "I", AccessFlags = 25)]
						public const int IsDefault = 16843297;
						/// <java-name>
						/// isIndicator
						/// </java-name>
						[Dot42.DexImport("isIndicator", "I", AccessFlags = 25)]
						public const int IsIndicator = 16843079;
						/// <java-name>
						/// isModifier
						/// </java-name>
						[Dot42.DexImport("isModifier", "I", AccessFlags = 25)]
						public const int IsModifier = 16843334;
						/// <java-name>
						/// isRepeatable
						/// </java-name>
						[Dot42.DexImport("isRepeatable", "I", AccessFlags = 25)]
						public const int IsRepeatable = 16843336;
						/// <java-name>
						/// isScrollContainer
						/// </java-name>
						[Dot42.DexImport("isScrollContainer", "I", AccessFlags = 25)]
						public const int IsScrollContainer = 16843342;
						/// <java-name>
						/// isSticky
						/// </java-name>
						[Dot42.DexImport("isSticky", "I", AccessFlags = 25)]
						public const int IsSticky = 16843335;
						/// <java-name>
						/// itemBackground
						/// </java-name>
						[Dot42.DexImport("itemBackground", "I", AccessFlags = 25)]
						public const int ItemBackground = 16843056;
						/// <java-name>
						/// itemIconDisabledAlpha
						/// </java-name>
						[Dot42.DexImport("itemIconDisabledAlpha", "I", AccessFlags = 25)]
						public const int ItemIconDisabledAlpha = 16843057;
						/// <java-name>
						/// itemTextAppearance
						/// </java-name>
						[Dot42.DexImport("itemTextAppearance", "I", AccessFlags = 25)]
						public const int ItemTextAppearance = 16843052;
						/// <java-name>
						/// keepScreenOn
						/// </java-name>
						[Dot42.DexImport("keepScreenOn", "I", AccessFlags = 25)]
						public const int KeepScreenOn = 16843286;
						/// <java-name>
						/// key
						/// </java-name>
						[Dot42.DexImport("key", "I", AccessFlags = 25)]
						public const int Key = 16843240;
						/// <java-name>
						/// keyBackground
						/// </java-name>
						[Dot42.DexImport("keyBackground", "I", AccessFlags = 25)]
						public const int KeyBackground = 16843315;
						/// <java-name>
						/// keyEdgeFlags
						/// </java-name>
						[Dot42.DexImport("keyEdgeFlags", "I", AccessFlags = 25)]
						public const int KeyEdgeFlags = 16843333;
						/// <java-name>
						/// keyHeight
						/// </java-name>
						[Dot42.DexImport("keyHeight", "I", AccessFlags = 25)]
						public const int KeyHeight = 16843326;
						/// <java-name>
						/// keyIcon
						/// </java-name>
						[Dot42.DexImport("keyIcon", "I", AccessFlags = 25)]
						public const int KeyIcon = 16843340;
						/// <java-name>
						/// keyLabel
						/// </java-name>
						[Dot42.DexImport("keyLabel", "I", AccessFlags = 25)]
						public const int KeyLabel = 16843339;
						/// <java-name>
						/// keyOutputText
						/// </java-name>
						[Dot42.DexImport("keyOutputText", "I", AccessFlags = 25)]
						public const int KeyOutputText = 16843338;
						/// <java-name>
						/// keyPreviewHeight
						/// </java-name>
						[Dot42.DexImport("keyPreviewHeight", "I", AccessFlags = 25)]
						public const int KeyPreviewHeight = 16843321;
						/// <java-name>
						/// keyPreviewLayout
						/// </java-name>
						[Dot42.DexImport("keyPreviewLayout", "I", AccessFlags = 25)]
						public const int KeyPreviewLayout = 16843319;
						/// <java-name>
						/// keyPreviewOffset
						/// </java-name>
						[Dot42.DexImport("keyPreviewOffset", "I", AccessFlags = 25)]
						public const int KeyPreviewOffset = 16843320;
						/// <java-name>
						/// keyTextColor
						/// </java-name>
						[Dot42.DexImport("keyTextColor", "I", AccessFlags = 25)]
						public const int KeyTextColor = 16843318;
						/// <java-name>
						/// keyTextSize
						/// </java-name>
						[Dot42.DexImport("keyTextSize", "I", AccessFlags = 25)]
						public const int KeyTextSize = 16843316;
						/// <java-name>
						/// keyWidth
						/// </java-name>
						[Dot42.DexImport("keyWidth", "I", AccessFlags = 25)]
						public const int KeyWidth = 16843325;
						/// <java-name>
						/// keyboardMode
						/// </java-name>
						[Dot42.DexImport("keyboardMode", "I", AccessFlags = 25)]
						public const int KeyboardMode = 16843341;
						/// <java-name>
						/// keycode
						/// </java-name>
						[Dot42.DexImport("keycode", "I", AccessFlags = 25)]
						public const int Keycode = 16842949;
						/// <java-name>
						/// killAfterRestore
						/// </java-name>
						[Dot42.DexImport("killAfterRestore", "I", AccessFlags = 25)]
						public const int KillAfterRestore = 16843420;
						/// <java-name>
						/// label
						/// </java-name>
						[Dot42.DexImport("label", "I", AccessFlags = 25)]
						public const int Label = 16842753;
						/// <java-name>
						/// labelTextSize
						/// </java-name>
						[Dot42.DexImport("labelTextSize", "I", AccessFlags = 25)]
						public const int LabelTextSize = 16843317;
						/// <java-name>
						/// largeScreens
						/// </java-name>
						[Dot42.DexImport("largeScreens", "I", AccessFlags = 25)]
						public const int LargeScreens = 16843398;
						/// <java-name>
						/// launchMode
						/// </java-name>
						[Dot42.DexImport("launchMode", "I", AccessFlags = 25)]
						public const int LaunchMode = 16842781;
						/// <java-name>
						/// layout
						/// </java-name>
						[Dot42.DexImport("layout", "I", AccessFlags = 25)]
						public const int Layout = 16842994;
						/// <java-name>
						/// layoutAnimation
						/// </java-name>
						[Dot42.DexImport("layoutAnimation", "I", AccessFlags = 25)]
						public const int LayoutAnimation = 16842988;
						/// <java-name>
						/// layout_above
						/// </java-name>
						[Dot42.DexImport("layout_above", "I", AccessFlags = 25)]
						public const int Layout_above = 16843140;
						/// <java-name>
						/// layout_alignBaseline
						/// </java-name>
						[Dot42.DexImport("layout_alignBaseline", "I", AccessFlags = 25)]
						public const int Layout_alignBaseline = 16843142;
						/// <java-name>
						/// layout_alignBottom
						/// </java-name>
						[Dot42.DexImport("layout_alignBottom", "I", AccessFlags = 25)]
						public const int Layout_alignBottom = 16843146;
						/// <java-name>
						/// layout_alignLeft
						/// </java-name>
						[Dot42.DexImport("layout_alignLeft", "I", AccessFlags = 25)]
						public const int Layout_alignLeft = 16843143;
						/// <java-name>
						/// layout_alignParentBottom
						/// </java-name>
						[Dot42.DexImport("layout_alignParentBottom", "I", AccessFlags = 25)]
						public const int Layout_alignParentBottom = 16843150;
						/// <java-name>
						/// layout_alignParentLeft
						/// </java-name>
						[Dot42.DexImport("layout_alignParentLeft", "I", AccessFlags = 25)]
						public const int Layout_alignParentLeft = 16843147;
						/// <java-name>
						/// layout_alignParentRight
						/// </java-name>
						[Dot42.DexImport("layout_alignParentRight", "I", AccessFlags = 25)]
						public const int Layout_alignParentRight = 16843149;
						/// <java-name>
						/// layout_alignParentTop
						/// </java-name>
						[Dot42.DexImport("layout_alignParentTop", "I", AccessFlags = 25)]
						public const int Layout_alignParentTop = 16843148;
						/// <java-name>
						/// layout_alignRight
						/// </java-name>
						[Dot42.DexImport("layout_alignRight", "I", AccessFlags = 25)]
						public const int Layout_alignRight = 16843145;
						/// <java-name>
						/// layout_alignTop
						/// </java-name>
						[Dot42.DexImport("layout_alignTop", "I", AccessFlags = 25)]
						public const int Layout_alignTop = 16843144;
						/// <java-name>
						/// layout_alignWithParentIfMissing
						/// </java-name>
						[Dot42.DexImport("layout_alignWithParentIfMissing", "I", AccessFlags = 25)]
						public const int Layout_alignWithParentIfMissing = 16843154;
						/// <java-name>
						/// layout_below
						/// </java-name>
						[Dot42.DexImport("layout_below", "I", AccessFlags = 25)]
						public const int Layout_below = 16843141;
						/// <java-name>
						/// layout_centerHorizontal
						/// </java-name>
						[Dot42.DexImport("layout_centerHorizontal", "I", AccessFlags = 25)]
						public const int Layout_centerHorizontal = 16843152;
						/// <java-name>
						/// layout_centerInParent
						/// </java-name>
						[Dot42.DexImport("layout_centerInParent", "I", AccessFlags = 25)]
						public const int Layout_centerInParent = 16843151;
						/// <java-name>
						/// layout_centerVertical
						/// </java-name>
						[Dot42.DexImport("layout_centerVertical", "I", AccessFlags = 25)]
						public const int Layout_centerVertical = 16843153;
						/// <java-name>
						/// layout_column
						/// </java-name>
						[Dot42.DexImport("layout_column", "I", AccessFlags = 25)]
						public const int Layout_column = 16843084;
						/// <java-name>
						/// layout_gravity
						/// </java-name>
						[Dot42.DexImport("layout_gravity", "I", AccessFlags = 25)]
						public const int Layout_gravity = 16842931;
						/// <java-name>
						/// layout_height
						/// </java-name>
						[Dot42.DexImport("layout_height", "I", AccessFlags = 25)]
						public const int Layout_height = 16842997;
						/// <java-name>
						/// layout_margin
						/// </java-name>
						[Dot42.DexImport("layout_margin", "I", AccessFlags = 25)]
						public const int Layout_margin = 16842998;
						/// <java-name>
						/// layout_marginBottom
						/// </java-name>
						[Dot42.DexImport("layout_marginBottom", "I", AccessFlags = 25)]
						public const int Layout_marginBottom = 16843002;
						/// <java-name>
						/// layout_marginLeft
						/// </java-name>
						[Dot42.DexImport("layout_marginLeft", "I", AccessFlags = 25)]
						public const int Layout_marginLeft = 16842999;
						/// <java-name>
						/// layout_marginRight
						/// </java-name>
						[Dot42.DexImport("layout_marginRight", "I", AccessFlags = 25)]
						public const int Layout_marginRight = 16843001;
						/// <java-name>
						/// layout_marginTop
						/// </java-name>
						[Dot42.DexImport("layout_marginTop", "I", AccessFlags = 25)]
						public const int Layout_marginTop = 16843000;
						/// <java-name>
						/// layout_scale
						/// </java-name>
						[Dot42.DexImport("layout_scale", "I", AccessFlags = 25)]
						public const int Layout_scale = 16843155;
						/// <java-name>
						/// layout_span
						/// </java-name>
						[Dot42.DexImport("layout_span", "I", AccessFlags = 25)]
						public const int Layout_span = 16843085;
						/// <java-name>
						/// layout_toLeftOf
						/// </java-name>
						[Dot42.DexImport("layout_toLeftOf", "I", AccessFlags = 25)]
						public const int Layout_toLeftOf = 16843138;
						/// <java-name>
						/// layout_toRightOf
						/// </java-name>
						[Dot42.DexImport("layout_toRightOf", "I", AccessFlags = 25)]
						public const int Layout_toRightOf = 16843139;
						/// <java-name>
						/// layout_weight
						/// </java-name>
						[Dot42.DexImport("layout_weight", "I", AccessFlags = 25)]
						public const int Layout_weight = 16843137;
						/// <java-name>
						/// layout_width
						/// </java-name>
						[Dot42.DexImport("layout_width", "I", AccessFlags = 25)]
						public const int Layout_width = 16842996;
						/// <java-name>
						/// layout_x
						/// </java-name>
						[Dot42.DexImport("layout_x", "I", AccessFlags = 25)]
						public const int Layout_x = 16843135;
						/// <java-name>
						/// layout_y
						/// </java-name>
						[Dot42.DexImport("layout_y", "I", AccessFlags = 25)]
						public const int Layout_y = 16843136;
						/// <java-name>
						/// left
						/// </java-name>
						[Dot42.DexImport("left", "I", AccessFlags = 25)]
						public const int Left = 16843181;
						/// <java-name>
						/// lineSpacingExtra
						/// </java-name>
						[Dot42.DexImport("lineSpacingExtra", "I", AccessFlags = 25)]
						public const int LineSpacingExtra = 16843287;
						/// <java-name>
						/// lineSpacingMultiplier
						/// </java-name>
						[Dot42.DexImport("lineSpacingMultiplier", "I", AccessFlags = 25)]
						public const int LineSpacingMultiplier = 16843288;
						/// <java-name>
						/// lines
						/// </java-name>
						[Dot42.DexImport("lines", "I", AccessFlags = 25)]
						public const int Lines = 16843092;
						/// <java-name>
						/// linksClickable
						/// </java-name>
						[Dot42.DexImport("linksClickable", "I", AccessFlags = 25)]
						public const int LinksClickable = 16842929;
						/// <java-name>
						/// listChoiceIndicatorMultiple
						/// </java-name>
						[Dot42.DexImport("listChoiceIndicatorMultiple", "I", AccessFlags = 25)]
						public const int ListChoiceIndicatorMultiple = 16843290;
						/// <java-name>
						/// listChoiceIndicatorSingle
						/// </java-name>
						[Dot42.DexImport("listChoiceIndicatorSingle", "I", AccessFlags = 25)]
						public const int ListChoiceIndicatorSingle = 16843289;
						/// <java-name>
						/// listDivider
						/// </java-name>
						[Dot42.DexImport("listDivider", "I", AccessFlags = 25)]
						public const int ListDivider = 16843284;
						/// <java-name>
						/// listPreferredItemHeight
						/// </java-name>
						[Dot42.DexImport("listPreferredItemHeight", "I", AccessFlags = 25)]
						public const int ListPreferredItemHeight = 16842829;
						/// <java-name>
						/// listSelector
						/// </java-name>
						[Dot42.DexImport("listSelector", "I", AccessFlags = 25)]
						public const int ListSelector = 16843003;
						/// <java-name>
						/// listSeparatorTextViewStyle
						/// </java-name>
						[Dot42.DexImport("listSeparatorTextViewStyle", "I", AccessFlags = 25)]
						public const int ListSeparatorTextViewStyle = 16843272;
						/// <java-name>
						/// listViewStyle
						/// </java-name>
						[Dot42.DexImport("listViewStyle", "I", AccessFlags = 25)]
						public const int ListViewStyle = 16842868;
						/// <java-name>
						/// listViewWhiteStyle
						/// </java-name>
						[Dot42.DexImport("listViewWhiteStyle", "I", AccessFlags = 25)]
						public const int ListViewWhiteStyle = 16842869;
						/// <java-name>
						/// longClickable
						/// </java-name>
						[Dot42.DexImport("longClickable", "I", AccessFlags = 25)]
						public const int LongClickable = 16842982;
						/// <java-name>
						/// manageSpaceActivity
						/// </java-name>
						[Dot42.DexImport("manageSpaceActivity", "I", AccessFlags = 25)]
						public const int ManageSpaceActivity = 16842756;
						/// <java-name>
						/// mapViewStyle
						/// </java-name>
						[Dot42.DexImport("mapViewStyle", "I", AccessFlags = 25)]
						public const int MapViewStyle = 16842890;
						/// <java-name>
						/// marqueeRepeatLimit
						/// </java-name>
						[Dot42.DexImport("marqueeRepeatLimit", "I", AccessFlags = 25)]
						public const int MarqueeRepeatLimit = 16843293;
						/// <java-name>
						/// max
						/// </java-name>
						[Dot42.DexImport("max", "I", AccessFlags = 25)]
						public const int Max = 16843062;
						/// <java-name>
						/// maxEms
						/// </java-name>
						[Dot42.DexImport("maxEms", "I", AccessFlags = 25)]
						public const int MaxEms = 16843095;
						/// <java-name>
						/// maxHeight
						/// </java-name>
						[Dot42.DexImport("maxHeight", "I", AccessFlags = 25)]
						public const int MaxHeight = 16843040;
						/// <java-name>
						/// maxItemsPerRow
						/// </java-name>
						[Dot42.DexImport("maxItemsPerRow", "I", AccessFlags = 25)]
						public const int MaxItemsPerRow = 16843060;
						/// <java-name>
						/// maxLength
						/// </java-name>
						[Dot42.DexImport("maxLength", "I", AccessFlags = 25)]
						public const int MaxLength = 16843104;
						/// <java-name>
						/// maxLevel
						/// </java-name>
						[Dot42.DexImport("maxLevel", "I", AccessFlags = 25)]
						public const int MaxLevel = 16843186;
						/// <java-name>
						/// maxLines
						/// </java-name>
						[Dot42.DexImport("maxLines", "I", AccessFlags = 25)]
						public const int MaxLines = 16843091;
						/// <java-name>
						/// maxRows
						/// </java-name>
						[Dot42.DexImport("maxRows", "I", AccessFlags = 25)]
						public const int MaxRows = 16843059;
						/// <java-name>
						/// maxSdkVersion
						/// </java-name>
						[Dot42.DexImport("maxSdkVersion", "I", AccessFlags = 25)]
						public const int MaxSdkVersion = 16843377;
						/// <java-name>
						/// maxWidth
						/// </java-name>
						[Dot42.DexImport("maxWidth", "I", AccessFlags = 25)]
						public const int MaxWidth = 16843039;
						/// <java-name>
						/// measureAllChildren
						/// </java-name>
						[Dot42.DexImport("measureAllChildren", "I", AccessFlags = 25)]
						public const int MeasureAllChildren = 16843018;
						/// <java-name>
						/// menuCategory
						/// </java-name>
						[Dot42.DexImport("menuCategory", "I", AccessFlags = 25)]
						public const int MenuCategory = 16843230;
						/// <java-name>
						/// mimeType
						/// </java-name>
						[Dot42.DexImport("mimeType", "I", AccessFlags = 25)]
						public const int MimeType = 16842790;
						/// <java-name>
						/// minEms
						/// </java-name>
						[Dot42.DexImport("minEms", "I", AccessFlags = 25)]
						public const int MinEms = 16843098;
						/// <java-name>
						/// minHeight
						/// </java-name>
						[Dot42.DexImport("minHeight", "I", AccessFlags = 25)]
						public const int MinHeight = 16843072;
						/// <java-name>
						/// minLevel
						/// </java-name>
						[Dot42.DexImport("minLevel", "I", AccessFlags = 25)]
						public const int MinLevel = 16843185;
						/// <java-name>
						/// minLines
						/// </java-name>
						[Dot42.DexImport("minLines", "I", AccessFlags = 25)]
						public const int MinLines = 16843094;
						/// <java-name>
						/// minSdkVersion
						/// </java-name>
						[Dot42.DexImport("minSdkVersion", "I", AccessFlags = 25)]
						public const int MinSdkVersion = 16843276;
						/// <java-name>
						/// minWidth
						/// </java-name>
						[Dot42.DexImport("minWidth", "I", AccessFlags = 25)]
						public const int MinWidth = 16843071;
						/// <java-name>
						/// mode
						/// </java-name>
						[Dot42.DexImport("mode", "I", AccessFlags = 25)]
						public const int Mode = 16843134;
						/// <java-name>
						/// moreIcon
						/// </java-name>
						[Dot42.DexImport("moreIcon", "I", AccessFlags = 25)]
						public const int MoreIcon = 16843061;
						/// <java-name>
						/// multiprocess
						/// </java-name>
						[Dot42.DexImport("multiprocess", "I", AccessFlags = 25)]
						public const int Multiprocess = 16842771;
						/// <java-name>
						/// name
						/// </java-name>
						[Dot42.DexImport("name", "I", AccessFlags = 25)]
						public const int Name = 16842755;
						/// <java-name>
						/// negativeButtonText
						/// </java-name>
						[Dot42.DexImport("negativeButtonText", "I", AccessFlags = 25)]
						public const int NegativeButtonText = 16843254;
						/// <java-name>
						/// nextFocusDown
						/// </java-name>
						[Dot42.DexImport("nextFocusDown", "I", AccessFlags = 25)]
						public const int NextFocusDown = 16842980;
						/// <java-name>
						/// nextFocusLeft
						/// </java-name>
						[Dot42.DexImport("nextFocusLeft", "I", AccessFlags = 25)]
						public const int NextFocusLeft = 16842977;
						/// <java-name>
						/// nextFocusRight
						/// </java-name>
						[Dot42.DexImport("nextFocusRight", "I", AccessFlags = 25)]
						public const int NextFocusRight = 16842978;
						/// <java-name>
						/// nextFocusUp
						/// </java-name>
						[Dot42.DexImport("nextFocusUp", "I", AccessFlags = 25)]
						public const int NextFocusUp = 16842979;
						/// <java-name>
						/// noHistory
						/// </java-name>
						[Dot42.DexImport("noHistory", "I", AccessFlags = 25)]
						public const int NoHistory = 16843309;
						/// <java-name>
						/// normalScreens
						/// </java-name>
						[Dot42.DexImport("normalScreens", "I", AccessFlags = 25)]
						public const int NormalScreens = 16843397;
						/// <java-name>
						/// numColumns
						/// </java-name>
						[Dot42.DexImport("numColumns", "I", AccessFlags = 25)]
						public const int NumColumns = 16843032;
						/// <java-name>
						/// numStars
						/// </java-name>
						[Dot42.DexImport("numStars", "I", AccessFlags = 25)]
						public const int NumStars = 16843076;
						/// <java-name>
						/// numeric
						/// </java-name>
						[Dot42.DexImport("numeric", "I", AccessFlags = 25)]
						public const int Numeric = 16843109;
						/// <java-name>
						/// numericShortcut
						/// </java-name>
						[Dot42.DexImport("numericShortcut", "I", AccessFlags = 25)]
						public const int NumericShortcut = 16843236;
						/// <java-name>
						/// onClick
						/// </java-name>
						[Dot42.DexImport("onClick", "I", AccessFlags = 25)]
						public const int OnClick = 16843375;
						/// <java-name>
						/// oneshot
						/// </java-name>
						[Dot42.DexImport("oneshot", "I", AccessFlags = 25)]
						public const int Oneshot = 16843159;
						/// <java-name>
						/// order
						/// </java-name>
						[Dot42.DexImport("order", "I", AccessFlags = 25)]
						public const int Order = 16843242;
						/// <java-name>
						/// orderInCategory
						/// </java-name>
						[Dot42.DexImport("orderInCategory", "I", AccessFlags = 25)]
						public const int OrderInCategory = 16843231;
						/// <java-name>
						/// orderingFromXml
						/// </java-name>
						[Dot42.DexImport("orderingFromXml", "I", AccessFlags = 25)]
						public const int OrderingFromXml = 16843239;
						/// <java-name>
						/// orientation
						/// </java-name>
						[Dot42.DexImport("orientation", "I", AccessFlags = 25)]
						public const int Orientation = 16842948;
						/// <java-name>
						/// outAnimation
						/// </java-name>
						[Dot42.DexImport("outAnimation", "I", AccessFlags = 25)]
						public const int OutAnimation = 16843128;
						/// <java-name>
						/// padding
						/// </java-name>
						[Dot42.DexImport("padding", "I", AccessFlags = 25)]
						public const int Padding = 16842965;
						/// <java-name>
						/// paddingBottom
						/// </java-name>
						[Dot42.DexImport("paddingBottom", "I", AccessFlags = 25)]
						public const int PaddingBottom = 16842969;
						/// <java-name>
						/// paddingLeft
						/// </java-name>
						[Dot42.DexImport("paddingLeft", "I", AccessFlags = 25)]
						public const int PaddingLeft = 16842966;
						/// <java-name>
						/// paddingRight
						/// </java-name>
						[Dot42.DexImport("paddingRight", "I", AccessFlags = 25)]
						public const int PaddingRight = 16842968;
						/// <java-name>
						/// paddingTop
						/// </java-name>
						[Dot42.DexImport("paddingTop", "I", AccessFlags = 25)]
						public const int PaddingTop = 16842967;
						/// <java-name>
						/// panelBackground
						/// </java-name>
						[Dot42.DexImport("panelBackground", "I", AccessFlags = 25)]
						public const int PanelBackground = 16842846;
						/// <java-name>
						/// panelColorBackground
						/// </java-name>
						[Dot42.DexImport("panelColorBackground", "I", AccessFlags = 25)]
						public const int PanelColorBackground = 16842849;
						/// <java-name>
						/// panelColorForeground
						/// </java-name>
						[Dot42.DexImport("panelColorForeground", "I", AccessFlags = 25)]
						public const int PanelColorForeground = 16842848;
						/// <java-name>
						/// panelFullBackground
						/// </java-name>
						[Dot42.DexImport("panelFullBackground", "I", AccessFlags = 25)]
						public const int PanelFullBackground = 16842847;
						/// <java-name>
						/// panelTextAppearance
						/// </java-name>
						[Dot42.DexImport("panelTextAppearance", "I", AccessFlags = 25)]
						public const int PanelTextAppearance = 16842850;
						/// <java-name>
						/// password
						/// </java-name>
						[Dot42.DexImport("password", "I", AccessFlags = 25)]
						public const int Password = 16843100;
						/// <java-name>
						/// path
						/// </java-name>
						[Dot42.DexImport("path", "I", AccessFlags = 25)]
						public const int Path = 16842794;
						/// <java-name>
						/// pathPattern
						/// </java-name>
						[Dot42.DexImport("pathPattern", "I", AccessFlags = 25)]
						public const int PathPattern = 16842796;
						/// <java-name>
						/// pathPrefix
						/// </java-name>
						[Dot42.DexImport("pathPrefix", "I", AccessFlags = 25)]
						public const int PathPrefix = 16842795;
						/// <java-name>
						/// permission
						/// </java-name>
						[Dot42.DexImport("permission", "I", AccessFlags = 25)]
						public const int Permission = 16842758;
						/// <java-name>
						/// permissionGroup
						/// </java-name>
						[Dot42.DexImport("permissionGroup", "I", AccessFlags = 25)]
						public const int PermissionGroup = 16842762;
						/// <java-name>
						/// persistent
						/// </java-name>
						[Dot42.DexImport("persistent", "I", AccessFlags = 25)]
						public const int Persistent = 16842765;
						/// <java-name>
						/// persistentDrawingCache
						/// </java-name>
						[Dot42.DexImport("persistentDrawingCache", "I", AccessFlags = 25)]
						public const int PersistentDrawingCache = 16842990;
						/// <java-name>
						/// phoneNumber
						/// </java-name>
						[Dot42.DexImport("phoneNumber", "I", AccessFlags = 25)]
						public const int PhoneNumber = 16843111;
						/// <java-name>
						/// pivotX
						/// </java-name>
						[Dot42.DexImport("pivotX", "I", AccessFlags = 25)]
						public const int PivotX = 16843189;
						/// <java-name>
						/// pivotY
						/// </java-name>
						[Dot42.DexImport("pivotY", "I", AccessFlags = 25)]
						public const int PivotY = 16843190;
						/// <java-name>
						/// popupBackground
						/// </java-name>
						[Dot42.DexImport("popupBackground", "I", AccessFlags = 25)]
						public const int PopupBackground = 16843126;
						/// <java-name>
						/// popupCharacters
						/// </java-name>
						[Dot42.DexImport("popupCharacters", "I", AccessFlags = 25)]
						public const int PopupCharacters = 16843332;
						/// <java-name>
						/// popupKeyboard
						/// </java-name>
						[Dot42.DexImport("popupKeyboard", "I", AccessFlags = 25)]
						public const int PopupKeyboard = 16843331;
						/// <java-name>
						/// popupLayout
						/// </java-name>
						[Dot42.DexImport("popupLayout", "I", AccessFlags = 25)]
						public const int PopupLayout = 16843323;
						/// <java-name>
						/// popupWindowStyle
						/// </java-name>
						[Dot42.DexImport("popupWindowStyle", "I", AccessFlags = 25)]
						public const int PopupWindowStyle = 16842870;
						/// <java-name>
						/// port
						/// </java-name>
						[Dot42.DexImport("port", "I", AccessFlags = 25)]
						public const int Port = 16842793;
						/// <java-name>
						/// positiveButtonText
						/// </java-name>
						[Dot42.DexImport("positiveButtonText", "I", AccessFlags = 25)]
						public const int PositiveButtonText = 16843253;
						/// <java-name>
						/// preferenceCategoryStyle
						/// </java-name>
						[Dot42.DexImport("preferenceCategoryStyle", "I", AccessFlags = 25)]
						public const int PreferenceCategoryStyle = 16842892;
						/// <java-name>
						/// preferenceInformationStyle
						/// </java-name>
						[Dot42.DexImport("preferenceInformationStyle", "I", AccessFlags = 25)]
						public const int PreferenceInformationStyle = 16842893;
						/// <java-name>
						/// preferenceLayoutChild
						/// </java-name>
						[Dot42.DexImport("preferenceLayoutChild", "I", AccessFlags = 25)]
						public const int PreferenceLayoutChild = 16842900;
						/// <java-name>
						/// preferenceScreenStyle
						/// </java-name>
						[Dot42.DexImport("preferenceScreenStyle", "I", AccessFlags = 25)]
						public const int PreferenceScreenStyle = 16842891;
						/// <java-name>
						/// preferenceStyle
						/// </java-name>
						[Dot42.DexImport("preferenceStyle", "I", AccessFlags = 25)]
						public const int PreferenceStyle = 16842894;
						/// <java-name>
						/// priority
						/// </java-name>
						[Dot42.DexImport("priority", "I", AccessFlags = 25)]
						public const int Priority = 16842780;
						/// <java-name>
						/// privateImeOptions
						/// </java-name>
						[Dot42.DexImport("privateImeOptions", "I", AccessFlags = 25)]
						public const int PrivateImeOptions = 16843299;
						/// <java-name>
						/// process
						/// </java-name>
						[Dot42.DexImport("process", "I", AccessFlags = 25)]
						public const int Process = 16842769;
						/// <java-name>
						/// progress
						/// </java-name>
						[Dot42.DexImport("progress", "I", AccessFlags = 25)]
						public const int Progress = 16843063;
						/// <java-name>
						/// progressBarStyle
						/// </java-name>
						[Dot42.DexImport("progressBarStyle", "I", AccessFlags = 25)]
						public const int ProgressBarStyle = 16842871;
						/// <java-name>
						/// progressBarStyleHorizontal
						/// </java-name>
						[Dot42.DexImport("progressBarStyleHorizontal", "I", AccessFlags = 25)]
						public const int ProgressBarStyleHorizontal = 16842872;
						/// <java-name>
						/// progressBarStyleInverse
						/// </java-name>
						[Dot42.DexImport("progressBarStyleInverse", "I", AccessFlags = 25)]
						public const int ProgressBarStyleInverse = 16843399;
						/// <java-name>
						/// progressBarStyleLarge
						/// </java-name>
						[Dot42.DexImport("progressBarStyleLarge", "I", AccessFlags = 25)]
						public const int ProgressBarStyleLarge = 16842874;
						/// <java-name>
						/// progressBarStyleLargeInverse
						/// </java-name>
						[Dot42.DexImport("progressBarStyleLargeInverse", "I", AccessFlags = 25)]
						public const int ProgressBarStyleLargeInverse = 16843401;
						/// <java-name>
						/// progressBarStyleSmall
						/// </java-name>
						[Dot42.DexImport("progressBarStyleSmall", "I", AccessFlags = 25)]
						public const int ProgressBarStyleSmall = 16842873;
						/// <java-name>
						/// progressBarStyleSmallInverse
						/// </java-name>
						[Dot42.DexImport("progressBarStyleSmallInverse", "I", AccessFlags = 25)]
						public const int ProgressBarStyleSmallInverse = 16843400;
						/// <java-name>
						/// progressBarStyleSmallTitle
						/// </java-name>
						[Dot42.DexImport("progressBarStyleSmallTitle", "I", AccessFlags = 25)]
						public const int ProgressBarStyleSmallTitle = 16843279;
						/// <java-name>
						/// progressDrawable
						/// </java-name>
						[Dot42.DexImport("progressDrawable", "I", AccessFlags = 25)]
						public const int ProgressDrawable = 16843068;
						/// <java-name>
						/// prompt
						/// </java-name>
						[Dot42.DexImport("prompt", "I", AccessFlags = 25)]
						public const int Prompt = 16843131;
						/// <java-name>
						/// protectionLevel
						/// </java-name>
						[Dot42.DexImport("protectionLevel", "I", AccessFlags = 25)]
						public const int ProtectionLevel = 16842761;
						/// <java-name>
						/// queryActionMsg
						/// </java-name>
						[Dot42.DexImport("queryActionMsg", "I", AccessFlags = 25)]
						public const int QueryActionMsg = 16843227;
						/// <java-name>
						/// queryAfterZeroResults
						/// </java-name>
						[Dot42.DexImport("queryAfterZeroResults", "I", AccessFlags = 25)]
						public const int QueryAfterZeroResults = 16843394;
						/// <java-name>
						/// quickContactBadgeStyleSmallWindowLarge
						/// </java-name>
						[Dot42.DexImport("quickContactBadgeStyleSmallWindowLarge", "I", AccessFlags = 25)]
						public const int QuickContactBadgeStyleSmallWindowLarge = 16843443;
						/// <java-name>
						/// quickContactBadgeStyleSmallWindowMedium
						/// </java-name>
						[Dot42.DexImport("quickContactBadgeStyleSmallWindowMedium", "I", AccessFlags = 25)]
						public const int QuickContactBadgeStyleSmallWindowMedium = 16843442;
						/// <java-name>
						/// quickContactBadgeStyleSmallWindowSmall
						/// </java-name>
						[Dot42.DexImport("quickContactBadgeStyleSmallWindowSmall", "I", AccessFlags = 25)]
						public const int QuickContactBadgeStyleSmallWindowSmall = 16843441;
						/// <java-name>
						/// quickContactBadgeStyleWindowLarge
						/// </java-name>
						[Dot42.DexImport("quickContactBadgeStyleWindowLarge", "I", AccessFlags = 25)]
						public const int QuickContactBadgeStyleWindowLarge = 16843440;
						/// <java-name>
						/// quickContactBadgeStyleWindowMedium
						/// </java-name>
						[Dot42.DexImport("quickContactBadgeStyleWindowMedium", "I", AccessFlags = 25)]
						public const int QuickContactBadgeStyleWindowMedium = 16843439;
						/// <java-name>
						/// quickContactBadgeStyleWindowSmall
						/// </java-name>
						[Dot42.DexImport("quickContactBadgeStyleWindowSmall", "I", AccessFlags = 25)]
						public const int QuickContactBadgeStyleWindowSmall = 16843438;
						/// <java-name>
						/// radioButtonStyle
						/// </java-name>
						[Dot42.DexImport("radioButtonStyle", "I", AccessFlags = 25)]
						public const int RadioButtonStyle = 16842878;
						/// <java-name>
						/// radius
						/// </java-name>
						[Dot42.DexImport("radius", "I", AccessFlags = 25)]
						public const int Radius = 16843176;
						/// <java-name>
						/// rating
						/// </java-name>
						[Dot42.DexImport("rating", "I", AccessFlags = 25)]
						public const int Rating = 16843077;
						/// <java-name>
						/// ratingBarStyle
						/// </java-name>
						[Dot42.DexImport("ratingBarStyle", "I", AccessFlags = 25)]
						public const int RatingBarStyle = 16842876;
						/// <java-name>
						/// ratingBarStyleIndicator
						/// </java-name>
						[Dot42.DexImport("ratingBarStyleIndicator", "I", AccessFlags = 25)]
						public const int RatingBarStyleIndicator = 16843280;
						/// <java-name>
						/// ratingBarStyleSmall
						/// </java-name>
						[Dot42.DexImport("ratingBarStyleSmall", "I", AccessFlags = 25)]
						public const int RatingBarStyleSmall = 16842877;
						/// <java-name>
						/// readPermission
						/// </java-name>
						[Dot42.DexImport("readPermission", "I", AccessFlags = 25)]
						public const int ReadPermission = 16842759;
						/// <java-name>
						/// repeatCount
						/// </java-name>
						[Dot42.DexImport("repeatCount", "I", AccessFlags = 25)]
						public const int RepeatCount = 16843199;
						/// <java-name>
						/// repeatMode
						/// </java-name>
						[Dot42.DexImport("repeatMode", "I", AccessFlags = 25)]
						public const int RepeatMode = 16843200;
						/// <java-name>
						/// reqFiveWayNav
						/// </java-name>
						[Dot42.DexImport("reqFiveWayNav", "I", AccessFlags = 25)]
						public const int ReqFiveWayNav = 16843314;
						/// <java-name>
						/// reqHardKeyboard
						/// </java-name>
						[Dot42.DexImport("reqHardKeyboard", "I", AccessFlags = 25)]
						public const int ReqHardKeyboard = 16843305;
						/// <java-name>
						/// reqKeyboardType
						/// </java-name>
						[Dot42.DexImport("reqKeyboardType", "I", AccessFlags = 25)]
						public const int ReqKeyboardType = 16843304;
						/// <java-name>
						/// reqNavigation
						/// </java-name>
						[Dot42.DexImport("reqNavigation", "I", AccessFlags = 25)]
						public const int ReqNavigation = 16843306;
						/// <java-name>
						/// reqTouchScreen
						/// </java-name>
						[Dot42.DexImport("reqTouchScreen", "I", AccessFlags = 25)]
						public const int ReqTouchScreen = 16843303;
						/// <java-name>
						/// required
						/// </java-name>
						[Dot42.DexImport("required", "I", AccessFlags = 25)]
						public const int Required = 16843406;
						/// <java-name>
						/// resizeable
						/// </java-name>
						[Dot42.DexImport("resizeable", "I", AccessFlags = 25)]
						public const int Resizeable = 16843405;
						/// <java-name>
						/// resource
						/// </java-name>
						[Dot42.DexImport("resource", "I", AccessFlags = 25)]
						public const int Resource = 16842789;
						/// <java-name>
						/// restoreNeedsApplication
						/// </java-name>
						[Dot42.DexImport("restoreNeedsApplication", "I", AccessFlags = 25)]
						public const int RestoreNeedsApplication = 16843421;
						/// <java-name>
						/// right
						/// </java-name>
						[Dot42.DexImport("right", "I", AccessFlags = 25)]
						public const int Right = 16843183;
						/// <java-name>
						/// ringtonePreferenceStyle
						/// </java-name>
						[Dot42.DexImport("ringtonePreferenceStyle", "I", AccessFlags = 25)]
						public const int RingtonePreferenceStyle = 16842899;
						/// <java-name>
						/// ringtoneType
						/// </java-name>
						[Dot42.DexImport("ringtoneType", "I", AccessFlags = 25)]
						public const int RingtoneType = 16843257;
						/// <java-name>
						/// rowDelay
						/// </java-name>
						[Dot42.DexImport("rowDelay", "I", AccessFlags = 25)]
						public const int RowDelay = 16843216;
						/// <java-name>
						/// rowEdgeFlags
						/// </java-name>
						[Dot42.DexImport("rowEdgeFlags", "I", AccessFlags = 25)]
						public const int RowEdgeFlags = 16843329;
						/// <java-name>
						/// rowHeight
						/// </java-name>
						[Dot42.DexImport("rowHeight", "I", AccessFlags = 25)]
						public const int RowHeight = 16843058;
						/// <java-name>
						/// saveEnabled
						/// </java-name>
						[Dot42.DexImport("saveEnabled", "I", AccessFlags = 25)]
						public const int SaveEnabled = 16842983;
						/// <java-name>
						/// scaleGravity
						/// </java-name>
						[Dot42.DexImport("scaleGravity", "I", AccessFlags = 25)]
						public const int ScaleGravity = 16843262;
						/// <java-name>
						/// scaleHeight
						/// </java-name>
						[Dot42.DexImport("scaleHeight", "I", AccessFlags = 25)]
						public const int ScaleHeight = 16843261;
						/// <java-name>
						/// scaleType
						/// </java-name>
						[Dot42.DexImport("scaleType", "I", AccessFlags = 25)]
						public const int ScaleType = 16843037;
						/// <java-name>
						/// scaleWidth
						/// </java-name>
						[Dot42.DexImport("scaleWidth", "I", AccessFlags = 25)]
						public const int ScaleWidth = 16843260;
						/// <java-name>
						/// scheme
						/// </java-name>
						[Dot42.DexImport("scheme", "I", AccessFlags = 25)]
						public const int Scheme = 16842791;
						/// <java-name>
						/// screenOrientation
						/// </java-name>
						[Dot42.DexImport("screenOrientation", "I", AccessFlags = 25)]
						public const int ScreenOrientation = 16842782;
						/// <java-name>
						/// scrollHorizontally
						/// </java-name>
						[Dot42.DexImport("scrollHorizontally", "I", AccessFlags = 25)]
						public const int ScrollHorizontally = 16843099;
						/// <java-name>
						/// scrollViewStyle
						/// </java-name>
						[Dot42.DexImport("scrollViewStyle", "I", AccessFlags = 25)]
						public const int ScrollViewStyle = 16842880;
						/// <java-name>
						/// scrollX
						/// </java-name>
						[Dot42.DexImport("scrollX", "I", AccessFlags = 25)]
						public const int ScrollX = 16842962;
						/// <java-name>
						/// scrollY
						/// </java-name>
						[Dot42.DexImport("scrollY", "I", AccessFlags = 25)]
						public const int ScrollY = 16842963;
						/// <java-name>
						/// scrollbarAlwaysDrawHorizontalTrack
						/// </java-name>
						[Dot42.DexImport("scrollbarAlwaysDrawHorizontalTrack", "I", AccessFlags = 25)]
						public const int ScrollbarAlwaysDrawHorizontalTrack = 16842856;
						/// <java-name>
						/// scrollbarAlwaysDrawVerticalTrack
						/// </java-name>
						[Dot42.DexImport("scrollbarAlwaysDrawVerticalTrack", "I", AccessFlags = 25)]
						public const int ScrollbarAlwaysDrawVerticalTrack = 16842857;
						/// <java-name>
						/// scrollbarDefaultDelayBeforeFade
						/// </java-name>
						[Dot42.DexImport("scrollbarDefaultDelayBeforeFade", "I", AccessFlags = 25)]
						public const int ScrollbarDefaultDelayBeforeFade = 16843433;
						/// <java-name>
						/// scrollbarFadeDuration
						/// </java-name>
						[Dot42.DexImport("scrollbarFadeDuration", "I", AccessFlags = 25)]
						public const int ScrollbarFadeDuration = 16843432;
						/// <java-name>
						/// scrollbarSize
						/// </java-name>
						[Dot42.DexImport("scrollbarSize", "I", AccessFlags = 25)]
						public const int ScrollbarSize = 16842851;
						/// <java-name>
						/// scrollbarStyle
						/// </java-name>
						[Dot42.DexImport("scrollbarStyle", "I", AccessFlags = 25)]
						public const int ScrollbarStyle = 16842879;
						/// <java-name>
						/// scrollbarThumbHorizontal
						/// </java-name>
						[Dot42.DexImport("scrollbarThumbHorizontal", "I", AccessFlags = 25)]
						public const int ScrollbarThumbHorizontal = 16842852;
						/// <java-name>
						/// scrollbarThumbVertical
						/// </java-name>
						[Dot42.DexImport("scrollbarThumbVertical", "I", AccessFlags = 25)]
						public const int ScrollbarThumbVertical = 16842853;
						/// <java-name>
						/// scrollbarTrackHorizontal
						/// </java-name>
						[Dot42.DexImport("scrollbarTrackHorizontal", "I", AccessFlags = 25)]
						public const int ScrollbarTrackHorizontal = 16842854;
						/// <java-name>
						/// scrollbarTrackVertical
						/// </java-name>
						[Dot42.DexImport("scrollbarTrackVertical", "I", AccessFlags = 25)]
						public const int ScrollbarTrackVertical = 16842855;
						/// <java-name>
						/// scrollbars
						/// </java-name>
						[Dot42.DexImport("scrollbars", "I", AccessFlags = 25)]
						public const int Scrollbars = 16842974;
						/// <java-name>
						/// scrollingCache
						/// </java-name>
						[Dot42.DexImport("scrollingCache", "I", AccessFlags = 25)]
						public const int ScrollingCache = 16843006;
						/// <java-name>
						/// searchButtonText
						/// </java-name>
						[Dot42.DexImport("searchButtonText", "I", AccessFlags = 25)]
						public const int SearchButtonText = 16843269;
						/// <java-name>
						/// searchMode
						/// </java-name>
						[Dot42.DexImport("searchMode", "I", AccessFlags = 25)]
						public const int SearchMode = 16843221;
						/// <java-name>
						/// searchSettingsDescription
						/// </java-name>
						[Dot42.DexImport("searchSettingsDescription", "I", AccessFlags = 25)]
						public const int SearchSettingsDescription = 16843402;
						/// <java-name>
						/// searchSuggestAuthority
						/// </java-name>
						[Dot42.DexImport("searchSuggestAuthority", "I", AccessFlags = 25)]
						public const int SearchSuggestAuthority = 16843222;
						/// <java-name>
						/// searchSuggestIntentAction
						/// </java-name>
						[Dot42.DexImport("searchSuggestIntentAction", "I", AccessFlags = 25)]
						public const int SearchSuggestIntentAction = 16843225;
						/// <java-name>
						/// searchSuggestIntentData
						/// </java-name>
						[Dot42.DexImport("searchSuggestIntentData", "I", AccessFlags = 25)]
						public const int SearchSuggestIntentData = 16843226;
						/// <java-name>
						/// searchSuggestPath
						/// </java-name>
						[Dot42.DexImport("searchSuggestPath", "I", AccessFlags = 25)]
						public const int SearchSuggestPath = 16843223;
						/// <java-name>
						/// searchSuggestSelection
						/// </java-name>
						[Dot42.DexImport("searchSuggestSelection", "I", AccessFlags = 25)]
						public const int SearchSuggestSelection = 16843224;
						/// <java-name>
						/// searchSuggestThreshold
						/// </java-name>
						[Dot42.DexImport("searchSuggestThreshold", "I", AccessFlags = 25)]
						public const int SearchSuggestThreshold = 16843373;
						/// <java-name>
						/// secondaryProgress
						/// </java-name>
						[Dot42.DexImport("secondaryProgress", "I", AccessFlags = 25)]
						public const int SecondaryProgress = 16843064;
						/// <java-name>
						/// seekBarStyle
						/// </java-name>
						[Dot42.DexImport("seekBarStyle", "I", AccessFlags = 25)]
						public const int SeekBarStyle = 16842875;
						/// <java-name>
						/// selectAllOnFocus
						/// </java-name>
						[Dot42.DexImport("selectAllOnFocus", "I", AccessFlags = 25)]
						public const int SelectAllOnFocus = 16843102;
						/// <java-name>
						/// selectable
						/// </java-name>
						[Dot42.DexImport("selectable", "I", AccessFlags = 25)]
						public const int Selectable = 16843238;
						/// <java-name>
						/// settingsActivity
						/// </java-name>
						[Dot42.DexImport("settingsActivity", "I", AccessFlags = 25)]
						public const int SettingsActivity = 16843301;
						/// <java-name>
						/// shadowColor
						/// </java-name>
						[Dot42.DexImport("shadowColor", "I", AccessFlags = 25)]
						public const int ShadowColor = 16843105;
						/// <java-name>
						/// shadowDx
						/// </java-name>
						[Dot42.DexImport("shadowDx", "I", AccessFlags = 25)]
						public const int ShadowDx = 16843106;
						/// <java-name>
						/// shadowDy
						/// </java-name>
						[Dot42.DexImport("shadowDy", "I", AccessFlags = 25)]
						public const int ShadowDy = 16843107;
						/// <java-name>
						/// shadowRadius
						/// </java-name>
						[Dot42.DexImport("shadowRadius", "I", AccessFlags = 25)]
						public const int ShadowRadius = 16843108;
						/// <java-name>
						/// shape
						/// </java-name>
						[Dot42.DexImport("shape", "I", AccessFlags = 25)]
						public const int Shape = 16843162;
						/// <java-name>
						/// shareInterpolator
						/// </java-name>
						[Dot42.DexImport("shareInterpolator", "I", AccessFlags = 25)]
						public const int ShareInterpolator = 16843195;
						/// <java-name>
						/// sharedUserId
						/// </java-name>
						[Dot42.DexImport("sharedUserId", "I", AccessFlags = 25)]
						public const int SharedUserId = 16842763;
						/// <java-name>
						/// sharedUserLabel
						/// </java-name>
						[Dot42.DexImport("sharedUserLabel", "I", AccessFlags = 25)]
						public const int SharedUserLabel = 16843361;
						/// <java-name>
						/// shouldDisableView
						/// </java-name>
						[Dot42.DexImport("shouldDisableView", "I", AccessFlags = 25)]
						public const int ShouldDisableView = 16843246;
						/// <java-name>
						/// showDefault
						/// </java-name>
						[Dot42.DexImport("showDefault", "I", AccessFlags = 25)]
						public const int ShowDefault = 16843258;
						/// <java-name>
						/// showSilent
						/// </java-name>
						[Dot42.DexImport("showSilent", "I", AccessFlags = 25)]
						public const int ShowSilent = 16843259;
						/// <java-name>
						/// shrinkColumns
						/// </java-name>
						[Dot42.DexImport("shrinkColumns", "I", AccessFlags = 25)]
						public const int ShrinkColumns = 16843082;
						/// <java-name>
						/// singleLine
						/// </java-name>
						[Dot42.DexImport("singleLine", "I", AccessFlags = 25)]
						public const int SingleLine = 16843101;
						/// <java-name>
						/// smallIcon
						/// </java-name>
						[Dot42.DexImport("smallIcon", "I", AccessFlags = 25)]
						public const int SmallIcon = 16843422;
						/// <java-name>
						/// smallScreens
						/// </java-name>
						[Dot42.DexImport("smallScreens", "I", AccessFlags = 25)]
						public const int SmallScreens = 16843396;
						/// <java-name>
						/// smoothScrollbar
						/// </java-name>
						[Dot42.DexImport("smoothScrollbar", "I", AccessFlags = 25)]
						public const int SmoothScrollbar = 16843313;
						/// <java-name>
						/// soundEffectsEnabled
						/// </java-name>
						[Dot42.DexImport("soundEffectsEnabled", "I", AccessFlags = 25)]
						public const int SoundEffectsEnabled = 16843285;
						/// <java-name>
						/// spacing
						/// </java-name>
						[Dot42.DexImport("spacing", "I", AccessFlags = 25)]
						public const int Spacing = 16843027;
						/// <java-name>
						/// spinnerDropDownItemStyle
						/// </java-name>
						[Dot42.DexImport("spinnerDropDownItemStyle", "I", AccessFlags = 25)]
						public const int SpinnerDropDownItemStyle = 16842887;
						/// <java-name>
						/// spinnerItemStyle
						/// </java-name>
						[Dot42.DexImport("spinnerItemStyle", "I", AccessFlags = 25)]
						public const int SpinnerItemStyle = 16842889;
						/// <java-name>
						/// spinnerStyle
						/// </java-name>
						[Dot42.DexImport("spinnerStyle", "I", AccessFlags = 25)]
						public const int SpinnerStyle = 16842881;
						/// <java-name>
						/// src
						/// </java-name>
						[Dot42.DexImport("src", "I", AccessFlags = 25)]
						public const int Src = 16843033;
						/// <java-name>
						/// stackFromBottom
						/// </java-name>
						[Dot42.DexImport("stackFromBottom", "I", AccessFlags = 25)]
						public const int StackFromBottom = 16843005;
						/// <java-name>
						/// starStyle
						/// </java-name>
						[Dot42.DexImport("starStyle", "I", AccessFlags = 25)]
						public const int StarStyle = 16842882;
						/// <java-name>
						/// startColor
						/// </java-name>
						[Dot42.DexImport("startColor", "I", AccessFlags = 25)]
						public const int StartColor = 16843165;
						/// <java-name>
						/// startOffset
						/// </java-name>
						[Dot42.DexImport("startOffset", "I", AccessFlags = 25)]
						public const int StartOffset = 16843198;
						/// <java-name>
						/// startYear
						/// </java-name>
						[Dot42.DexImport("startYear", "I", AccessFlags = 25)]
						public const int StartYear = 16843132;
						/// <java-name>
						/// stateNotNeeded
						/// </java-name>
						[Dot42.DexImport("stateNotNeeded", "I", AccessFlags = 25)]
						public const int StateNotNeeded = 16842774;
						/// <java-name>
						/// state_above_anchor
						/// </java-name>
						[Dot42.DexImport("state_above_anchor", "I", AccessFlags = 25)]
						public const int State_above_anchor = 16842922;
						/// <java-name>
						/// state_active
						/// </java-name>
						[Dot42.DexImport("state_active", "I", AccessFlags = 25)]
						public const int State_active = 16842914;
						/// <java-name>
						/// state_checkable
						/// </java-name>
						[Dot42.DexImport("state_checkable", "I", AccessFlags = 25)]
						public const int State_checkable = 16842911;
						/// <java-name>
						/// state_checked
						/// </java-name>
						[Dot42.DexImport("state_checked", "I", AccessFlags = 25)]
						public const int State_checked = 16842912;
						/// <java-name>
						/// state_empty
						/// </java-name>
						[Dot42.DexImport("state_empty", "I", AccessFlags = 25)]
						public const int State_empty = 16842921;
						/// <java-name>
						/// state_enabled
						/// </java-name>
						[Dot42.DexImport("state_enabled", "I", AccessFlags = 25)]
						public const int State_enabled = 16842910;
						/// <java-name>
						/// state_expanded
						/// </java-name>
						[Dot42.DexImport("state_expanded", "I", AccessFlags = 25)]
						public const int State_expanded = 16842920;
						/// <java-name>
						/// state_first
						/// </java-name>
						[Dot42.DexImport("state_first", "I", AccessFlags = 25)]
						public const int State_first = 16842916;
						/// <java-name>
						/// state_focused
						/// </java-name>
						[Dot42.DexImport("state_focused", "I", AccessFlags = 25)]
						public const int State_focused = 16842908;
						/// <java-name>
						/// state_last
						/// </java-name>
						[Dot42.DexImport("state_last", "I", AccessFlags = 25)]
						public const int State_last = 16842918;
						/// <java-name>
						/// state_long_pressable
						/// </java-name>
						[Dot42.DexImport("state_long_pressable", "I", AccessFlags = 25)]
						public const int State_long_pressable = 16843324;
						/// <java-name>
						/// state_middle
						/// </java-name>
						[Dot42.DexImport("state_middle", "I", AccessFlags = 25)]
						public const int State_middle = 16842917;
						/// <java-name>
						/// state_pressed
						/// </java-name>
						[Dot42.DexImport("state_pressed", "I", AccessFlags = 25)]
						public const int State_pressed = 16842919;
						/// <java-name>
						/// state_selected
						/// </java-name>
						[Dot42.DexImport("state_selected", "I", AccessFlags = 25)]
						public const int State_selected = 16842913;
						/// <java-name>
						/// state_single
						/// </java-name>
						[Dot42.DexImport("state_single", "I", AccessFlags = 25)]
						public const int State_single = 16842915;
						/// <java-name>
						/// state_window_focused
						/// </java-name>
						[Dot42.DexImport("state_window_focused", "I", AccessFlags = 25)]
						public const int State_window_focused = 16842909;
						/// <java-name>
						/// stepSize
						/// </java-name>
						[Dot42.DexImport("stepSize", "I", AccessFlags = 25)]
						public const int StepSize = 16843078;
						/// <java-name>
						/// streamType
						/// </java-name>
						[Dot42.DexImport("streamType", "I", AccessFlags = 25)]
						public const int StreamType = 16843273;
						/// <java-name>
						/// stretchColumns
						/// </java-name>
						[Dot42.DexImport("stretchColumns", "I", AccessFlags = 25)]
						public const int StretchColumns = 16843081;
						/// <java-name>
						/// stretchMode
						/// </java-name>
						[Dot42.DexImport("stretchMode", "I", AccessFlags = 25)]
						public const int StretchMode = 16843030;
						/// <java-name>
						/// suggestActionMsg
						/// </java-name>
						[Dot42.DexImport("suggestActionMsg", "I", AccessFlags = 25)]
						public const int SuggestActionMsg = 16843228;
						/// <java-name>
						/// suggestActionMsgColumn
						/// </java-name>
						[Dot42.DexImport("suggestActionMsgColumn", "I", AccessFlags = 25)]
						public const int SuggestActionMsgColumn = 16843229;
						/// <java-name>
						/// summary
						/// </java-name>
						[Dot42.DexImport("summary", "I", AccessFlags = 25)]
						public const int Summary = 16843241;
						/// <java-name>
						/// summaryColumn
						/// </java-name>
						[Dot42.DexImport("summaryColumn", "I", AccessFlags = 25)]
						public const int SummaryColumn = 16843426;
						/// <java-name>
						/// summaryOff
						/// </java-name>
						[Dot42.DexImport("summaryOff", "I", AccessFlags = 25)]
						public const int SummaryOff = 16843248;
						/// <java-name>
						/// summaryOn
						/// </java-name>
						[Dot42.DexImport("summaryOn", "I", AccessFlags = 25)]
						public const int SummaryOn = 16843247;
						/// <java-name>
						/// supportsUploading
						/// </java-name>
						[Dot42.DexImport("supportsUploading", "I", AccessFlags = 25)]
						public const int SupportsUploading = 16843419;
						/// <java-name>
						/// syncable
						/// </java-name>
						[Dot42.DexImport("syncable", "I", AccessFlags = 25)]
						public const int Syncable = 16842777;
						/// <java-name>
						/// tabWidgetStyle
						/// </java-name>
						[Dot42.DexImport("tabWidgetStyle", "I", AccessFlags = 25)]
						public const int TabWidgetStyle = 16842883;
						/// <java-name>
						/// tag
						/// </java-name>
						[Dot42.DexImport("tag", "I", AccessFlags = 25)]
						public const int Tag = 16842961;
						/// <java-name>
						/// targetActivity
						/// </java-name>
						[Dot42.DexImport("targetActivity", "I", AccessFlags = 25)]
						public const int TargetActivity = 16843266;
						/// <java-name>
						/// targetClass
						/// </java-name>
						[Dot42.DexImport("targetClass", "I", AccessFlags = 25)]
						public const int TargetClass = 16842799;
						/// <java-name>
						/// targetPackage
						/// </java-name>
						[Dot42.DexImport("targetPackage", "I", AccessFlags = 25)]
						public const int TargetPackage = 16842785;
						/// <java-name>
						/// targetSdkVersion
						/// </java-name>
						[Dot42.DexImport("targetSdkVersion", "I", AccessFlags = 25)]
						public const int TargetSdkVersion = 16843376;
						/// <java-name>
						/// taskAffinity
						/// </java-name>
						[Dot42.DexImport("taskAffinity", "I", AccessFlags = 25)]
						public const int TaskAffinity = 16842770;
						/// <java-name>
						/// taskCloseEnterAnimation
						/// </java-name>
						[Dot42.DexImport("taskCloseEnterAnimation", "I", AccessFlags = 25)]
						public const int TaskCloseEnterAnimation = 16842942;
						/// <java-name>
						/// taskCloseExitAnimation
						/// </java-name>
						[Dot42.DexImport("taskCloseExitAnimation", "I", AccessFlags = 25)]
						public const int TaskCloseExitAnimation = 16842943;
						/// <java-name>
						/// taskOpenEnterAnimation
						/// </java-name>
						[Dot42.DexImport("taskOpenEnterAnimation", "I", AccessFlags = 25)]
						public const int TaskOpenEnterAnimation = 16842940;
						/// <java-name>
						/// taskOpenExitAnimation
						/// </java-name>
						[Dot42.DexImport("taskOpenExitAnimation", "I", AccessFlags = 25)]
						public const int TaskOpenExitAnimation = 16842941;
						/// <java-name>
						/// taskToBackEnterAnimation
						/// </java-name>
						[Dot42.DexImport("taskToBackEnterAnimation", "I", AccessFlags = 25)]
						public const int TaskToBackEnterAnimation = 16842946;
						/// <java-name>
						/// taskToBackExitAnimation
						/// </java-name>
						[Dot42.DexImport("taskToBackExitAnimation", "I", AccessFlags = 25)]
						public const int TaskToBackExitAnimation = 16842947;
						/// <java-name>
						/// taskToFrontEnterAnimation
						/// </java-name>
						[Dot42.DexImport("taskToFrontEnterAnimation", "I", AccessFlags = 25)]
						public const int TaskToFrontEnterAnimation = 16842944;
						/// <java-name>
						/// taskToFrontExitAnimation
						/// </java-name>
						[Dot42.DexImport("taskToFrontExitAnimation", "I", AccessFlags = 25)]
						public const int TaskToFrontExitAnimation = 16842945;
						/// <java-name>
						/// tension
						/// </java-name>
						[Dot42.DexImport("tension", "I", AccessFlags = 25)]
						public const int Tension = 16843370;
						/// <java-name>
						/// testOnly
						/// </java-name>
						[Dot42.DexImport("testOnly", "I", AccessFlags = 25)]
						public const int TestOnly = 16843378;
						/// <java-name>
						/// text
						/// </java-name>
						[Dot42.DexImport("text", "I", AccessFlags = 25)]
						public const int Text = 16843087;
						/// <java-name>
						/// textAppearance
						/// </java-name>
						[Dot42.DexImport("textAppearance", "I", AccessFlags = 25)]
						public const int TextAppearance = 16842804;
						/// <java-name>
						/// textAppearanceButton
						/// </java-name>
						[Dot42.DexImport("textAppearanceButton", "I", AccessFlags = 25)]
						public const int TextAppearanceButton = 16843271;
						/// <java-name>
						/// textAppearanceInverse
						/// </java-name>
						[Dot42.DexImport("textAppearanceInverse", "I", AccessFlags = 25)]
						public const int TextAppearanceInverse = 16842805;
						/// <java-name>
						/// textAppearanceLarge
						/// </java-name>
						[Dot42.DexImport("textAppearanceLarge", "I", AccessFlags = 25)]
						public const int TextAppearanceLarge = 16842816;
						/// <java-name>
						/// textAppearanceLargeInverse
						/// </java-name>
						[Dot42.DexImport("textAppearanceLargeInverse", "I", AccessFlags = 25)]
						public const int TextAppearanceLargeInverse = 16842819;
						/// <java-name>
						/// textAppearanceMedium
						/// </java-name>
						[Dot42.DexImport("textAppearanceMedium", "I", AccessFlags = 25)]
						public const int TextAppearanceMedium = 16842817;
						/// <java-name>
						/// textAppearanceMediumInverse
						/// </java-name>
						[Dot42.DexImport("textAppearanceMediumInverse", "I", AccessFlags = 25)]
						public const int TextAppearanceMediumInverse = 16842820;
						/// <java-name>
						/// textAppearanceSearchResultSubtitle
						/// </java-name>
						[Dot42.DexImport("textAppearanceSearchResultSubtitle", "I", AccessFlags = 25)]
						public const int TextAppearanceSearchResultSubtitle = 16843424;
						/// <java-name>
						/// textAppearanceSearchResultTitle
						/// </java-name>
						[Dot42.DexImport("textAppearanceSearchResultTitle", "I", AccessFlags = 25)]
						public const int TextAppearanceSearchResultTitle = 16843425;
						/// <java-name>
						/// textAppearanceSmall
						/// </java-name>
						[Dot42.DexImport("textAppearanceSmall", "I", AccessFlags = 25)]
						public const int TextAppearanceSmall = 16842818;
						/// <java-name>
						/// textAppearanceSmallInverse
						/// </java-name>
						[Dot42.DexImport("textAppearanceSmallInverse", "I", AccessFlags = 25)]
						public const int TextAppearanceSmallInverse = 16842821;
						/// <java-name>
						/// textCheckMark
						/// </java-name>
						[Dot42.DexImport("textCheckMark", "I", AccessFlags = 25)]
						public const int TextCheckMark = 16842822;
						/// <java-name>
						/// textCheckMarkInverse
						/// </java-name>
						[Dot42.DexImport("textCheckMarkInverse", "I", AccessFlags = 25)]
						public const int TextCheckMarkInverse = 16842823;
						/// <java-name>
						/// textColor
						/// </java-name>
						[Dot42.DexImport("textColor", "I", AccessFlags = 25)]
						public const int TextColor = 16842904;
						/// <java-name>
						/// textColorHighlight
						/// </java-name>
						[Dot42.DexImport("textColorHighlight", "I", AccessFlags = 25)]
						public const int TextColorHighlight = 16842905;
						/// <java-name>
						/// textColorHint
						/// </java-name>
						[Dot42.DexImport("textColorHint", "I", AccessFlags = 25)]
						public const int TextColorHint = 16842906;
						/// <java-name>
						/// textColorHintInverse
						/// </java-name>
						[Dot42.DexImport("textColorHintInverse", "I", AccessFlags = 25)]
						public const int TextColorHintInverse = 16842815;
						/// <java-name>
						/// textColorLink
						/// </java-name>
						[Dot42.DexImport("textColorLink", "I", AccessFlags = 25)]
						public const int TextColorLink = 16842907;
						/// <java-name>
						/// textColorPrimary
						/// </java-name>
						[Dot42.DexImport("textColorPrimary", "I", AccessFlags = 25)]
						public const int TextColorPrimary = 16842806;
						/// <java-name>
						/// textColorPrimaryDisableOnly
						/// </java-name>
						[Dot42.DexImport("textColorPrimaryDisableOnly", "I", AccessFlags = 25)]
						public const int TextColorPrimaryDisableOnly = 16842807;
						/// <java-name>
						/// textColorPrimaryInverse
						/// </java-name>
						[Dot42.DexImport("textColorPrimaryInverse", "I", AccessFlags = 25)]
						public const int TextColorPrimaryInverse = 16842809;
						/// <java-name>
						/// textColorPrimaryInverseDisableOnly
						/// </java-name>
						[Dot42.DexImport("textColorPrimaryInverseDisableOnly", "I", AccessFlags = 25)]
						public const int TextColorPrimaryInverseDisableOnly = 16843403;
						/// <java-name>
						/// textColorPrimaryInverseNoDisable
						/// </java-name>
						[Dot42.DexImport("textColorPrimaryInverseNoDisable", "I", AccessFlags = 25)]
						public const int TextColorPrimaryInverseNoDisable = 16842813;
						/// <java-name>
						/// textColorPrimaryNoDisable
						/// </java-name>
						[Dot42.DexImport("textColorPrimaryNoDisable", "I", AccessFlags = 25)]
						public const int TextColorPrimaryNoDisable = 16842811;
						/// <java-name>
						/// textColorSecondary
						/// </java-name>
						[Dot42.DexImport("textColorSecondary", "I", AccessFlags = 25)]
						public const int TextColorSecondary = 16842808;
						/// <java-name>
						/// textColorSecondaryInverse
						/// </java-name>
						[Dot42.DexImport("textColorSecondaryInverse", "I", AccessFlags = 25)]
						public const int TextColorSecondaryInverse = 16842810;
						/// <java-name>
						/// textColorSecondaryInverseNoDisable
						/// </java-name>
						[Dot42.DexImport("textColorSecondaryInverseNoDisable", "I", AccessFlags = 25)]
						public const int TextColorSecondaryInverseNoDisable = 16842814;
						/// <java-name>
						/// textColorSecondaryNoDisable
						/// </java-name>
						[Dot42.DexImport("textColorSecondaryNoDisable", "I", AccessFlags = 25)]
						public const int TextColorSecondaryNoDisable = 16842812;
						/// <java-name>
						/// textColorTertiary
						/// </java-name>
						[Dot42.DexImport("textColorTertiary", "I", AccessFlags = 25)]
						public const int TextColorTertiary = 16843282;
						/// <java-name>
						/// textColorTertiaryInverse
						/// </java-name>
						[Dot42.DexImport("textColorTertiaryInverse", "I", AccessFlags = 25)]
						public const int TextColorTertiaryInverse = 16843283;
						/// <java-name>
						/// textFilterEnabled
						/// </java-name>
						[Dot42.DexImport("textFilterEnabled", "I", AccessFlags = 25)]
						public const int TextFilterEnabled = 16843007;
						/// <java-name>
						/// textOff
						/// </java-name>
						[Dot42.DexImport("textOff", "I", AccessFlags = 25)]
						public const int TextOff = 16843045;
						/// <java-name>
						/// textOn
						/// </java-name>
						[Dot42.DexImport("textOn", "I", AccessFlags = 25)]
						public const int TextOn = 16843044;
						/// <java-name>
						/// textScaleX
						/// </java-name>
						[Dot42.DexImport("textScaleX", "I", AccessFlags = 25)]
						public const int TextScaleX = 16843089;
						/// <java-name>
						/// textSize
						/// </java-name>
						[Dot42.DexImport("textSize", "I", AccessFlags = 25)]
						public const int TextSize = 16842901;
						/// <java-name>
						/// textStyle
						/// </java-name>
						[Dot42.DexImport("textStyle", "I", AccessFlags = 25)]
						public const int TextStyle = 16842903;
						/// <java-name>
						/// textViewStyle
						/// </java-name>
						[Dot42.DexImport("textViewStyle", "I", AccessFlags = 25)]
						public const int TextViewStyle = 16842884;
						/// <java-name>
						/// theme
						/// </java-name>
						[Dot42.DexImport("theme", "I", AccessFlags = 25)]
						public const int Theme = 16842752;
						/// <java-name>
						/// thickness
						/// </java-name>
						[Dot42.DexImport("thickness", "I", AccessFlags = 25)]
						public const int Thickness = 16843360;
						/// <java-name>
						/// thicknessRatio
						/// </java-name>
						[Dot42.DexImport("thicknessRatio", "I", AccessFlags = 25)]
						public const int ThicknessRatio = 16843164;
						/// <java-name>
						/// thumb
						/// </java-name>
						[Dot42.DexImport("thumb", "I", AccessFlags = 25)]
						public const int Thumb = 16843074;
						/// <java-name>
						/// thumbOffset
						/// </java-name>
						[Dot42.DexImport("thumbOffset", "I", AccessFlags = 25)]
						public const int ThumbOffset = 16843075;
						/// <java-name>
						/// thumbnail
						/// </java-name>
						[Dot42.DexImport("thumbnail", "I", AccessFlags = 25)]
						public const int Thumbnail = 16843429;
						/// <java-name>
						/// tileMode
						/// </java-name>
						[Dot42.DexImport("tileMode", "I", AccessFlags = 25)]
						public const int TileMode = 16843265;
						/// <java-name>
						/// tint
						/// </java-name>
						[Dot42.DexImport("tint", "I", AccessFlags = 25)]
						public const int Tint = 16843041;
						/// <java-name>
						/// title
						/// </java-name>
						[Dot42.DexImport("title", "I", AccessFlags = 25)]
						public const int Title = 16843233;
						/// <java-name>
						/// titleCondensed
						/// </java-name>
						[Dot42.DexImport("titleCondensed", "I", AccessFlags = 25)]
						public const int TitleCondensed = 16843234;
						/// <java-name>
						/// toAlpha
						/// </java-name>
						[Dot42.DexImport("toAlpha", "I", AccessFlags = 25)]
						public const int ToAlpha = 16843211;
						/// <java-name>
						/// toDegrees
						/// </java-name>
						[Dot42.DexImport("toDegrees", "I", AccessFlags = 25)]
						public const int ToDegrees = 16843188;
						/// <java-name>
						/// toXDelta
						/// </java-name>
						[Dot42.DexImport("toXDelta", "I", AccessFlags = 25)]
						public const int ToXDelta = 16843207;
						/// <java-name>
						/// toXScale
						/// </java-name>
						[Dot42.DexImport("toXScale", "I", AccessFlags = 25)]
						public const int ToXScale = 16843203;
						/// <java-name>
						/// toYDelta
						/// </java-name>
						[Dot42.DexImport("toYDelta", "I", AccessFlags = 25)]
						public const int ToYDelta = 16843209;
						/// <java-name>
						/// toYScale
						/// </java-name>
						[Dot42.DexImport("toYScale", "I", AccessFlags = 25)]
						public const int ToYScale = 16843205;
						/// <java-name>
						/// top
						/// </java-name>
						[Dot42.DexImport("top", "I", AccessFlags = 25)]
						public const int Top = 16843182;
						/// <java-name>
						/// topBright
						/// </java-name>
						[Dot42.DexImport("topBright", "I", AccessFlags = 25)]
						public const int TopBright = 16842955;
						/// <java-name>
						/// topDark
						/// </java-name>
						[Dot42.DexImport("topDark", "I", AccessFlags = 25)]
						public const int TopDark = 16842951;
						/// <java-name>
						/// topLeftRadius
						/// </java-name>
						[Dot42.DexImport("topLeftRadius", "I", AccessFlags = 25)]
						public const int TopLeftRadius = 16843177;
						/// <java-name>
						/// topOffset
						/// </java-name>
						[Dot42.DexImport("topOffset", "I", AccessFlags = 25)]
						public const int TopOffset = 16843352;
						/// <java-name>
						/// topRightRadius
						/// </java-name>
						[Dot42.DexImport("topRightRadius", "I", AccessFlags = 25)]
						public const int TopRightRadius = 16843178;
						/// <java-name>
						/// transcriptMode
						/// </java-name>
						[Dot42.DexImport("transcriptMode", "I", AccessFlags = 25)]
						public const int TranscriptMode = 16843008;
						/// <java-name>
						/// type
						/// </java-name>
						[Dot42.DexImport("type", "I", AccessFlags = 25)]
						public const int Type = 16843169;
						/// <java-name>
						/// typeface
						/// </java-name>
						[Dot42.DexImport("typeface", "I", AccessFlags = 25)]
						public const int Typeface = 16842902;
						/// <java-name>
						/// uncertainGestureColor
						/// </java-name>
						[Dot42.DexImport("uncertainGestureColor", "I", AccessFlags = 25)]
						public const int UncertainGestureColor = 16843382;
						/// <java-name>
						/// unselectedAlpha
						/// </java-name>
						[Dot42.DexImport("unselectedAlpha", "I", AccessFlags = 25)]
						public const int UnselectedAlpha = 16843278;
						/// <java-name>
						/// updatePeriodMillis
						/// </java-name>
						[Dot42.DexImport("updatePeriodMillis", "I", AccessFlags = 25)]
						public const int UpdatePeriodMillis = 16843344;
						/// <java-name>
						/// useLevel
						/// </java-name>
						[Dot42.DexImport("useLevel", "I", AccessFlags = 25)]
						public const int UseLevel = 16843167;
						/// <java-name>
						/// userVisible
						/// </java-name>
						[Dot42.DexImport("userVisible", "I", AccessFlags = 25)]
						public const int UserVisible = 16843409;
						/// <java-name>
						/// value
						/// </java-name>
						[Dot42.DexImport("value", "I", AccessFlags = 25)]
						public const int Value = 16842788;
						/// <java-name>
						/// variablePadding
						/// </java-name>
						[Dot42.DexImport("variablePadding", "I", AccessFlags = 25)]
						public const int VariablePadding = 16843157;
						/// <java-name>
						/// versionCode
						/// </java-name>
						[Dot42.DexImport("versionCode", "I", AccessFlags = 25)]
						public const int VersionCode = 16843291;
						/// <java-name>
						/// versionName
						/// </java-name>
						[Dot42.DexImport("versionName", "I", AccessFlags = 25)]
						public const int VersionName = 16843292;
						/// <java-name>
						/// verticalCorrection
						/// </java-name>
						[Dot42.DexImport("verticalCorrection", "I", AccessFlags = 25)]
						public const int VerticalCorrection = 16843322;
						/// <java-name>
						/// verticalDivider
						/// </java-name>
						[Dot42.DexImport("verticalDivider", "I", AccessFlags = 25)]
						public const int VerticalDivider = 16843054;
						/// <java-name>
						/// verticalGap
						/// </java-name>
						[Dot42.DexImport("verticalGap", "I", AccessFlags = 25)]
						public const int VerticalGap = 16843328;
						/// <java-name>
						/// verticalSpacing
						/// </java-name>
						[Dot42.DexImport("verticalSpacing", "I", AccessFlags = 25)]
						public const int VerticalSpacing = 16843029;
						/// <java-name>
						/// visibility
						/// </java-name>
						[Dot42.DexImport("visibility", "I", AccessFlags = 25)]
						public const int Visibility = 16842972;
						/// <java-name>
						/// visible
						/// </java-name>
						[Dot42.DexImport("visible", "I", AccessFlags = 25)]
						public const int Visible = 16843156;
						/// <java-name>
						/// voiceLanguage
						/// </java-name>
						[Dot42.DexImport("voiceLanguage", "I", AccessFlags = 25)]
						public const int VoiceLanguage = 16843349;
						/// <java-name>
						/// voiceLanguageModel
						/// </java-name>
						[Dot42.DexImport("voiceLanguageModel", "I", AccessFlags = 25)]
						public const int VoiceLanguageModel = 16843347;
						/// <java-name>
						/// voiceMaxResults
						/// </java-name>
						[Dot42.DexImport("voiceMaxResults", "I", AccessFlags = 25)]
						public const int VoiceMaxResults = 16843350;
						/// <java-name>
						/// voicePromptText
						/// </java-name>
						[Dot42.DexImport("voicePromptText", "I", AccessFlags = 25)]
						public const int VoicePromptText = 16843348;
						/// <java-name>
						/// voiceSearchMode
						/// </java-name>
						[Dot42.DexImport("voiceSearchMode", "I", AccessFlags = 25)]
						public const int VoiceSearchMode = 16843346;
						/// <java-name>
						/// wallpaperCloseEnterAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperCloseEnterAnimation", "I", AccessFlags = 25)]
						public const int WallpaperCloseEnterAnimation = 16843413;
						/// <java-name>
						/// wallpaperCloseExitAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperCloseExitAnimation", "I", AccessFlags = 25)]
						public const int WallpaperCloseExitAnimation = 16843414;
						/// <java-name>
						/// wallpaperIntraCloseEnterAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperIntraCloseEnterAnimation", "I", AccessFlags = 25)]
						public const int WallpaperIntraCloseEnterAnimation = 16843417;
						/// <java-name>
						/// wallpaperIntraCloseExitAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperIntraCloseExitAnimation", "I", AccessFlags = 25)]
						public const int WallpaperIntraCloseExitAnimation = 16843418;
						/// <java-name>
						/// wallpaperIntraOpenEnterAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperIntraOpenEnterAnimation", "I", AccessFlags = 25)]
						public const int WallpaperIntraOpenEnterAnimation = 16843415;
						/// <java-name>
						/// wallpaperIntraOpenExitAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperIntraOpenExitAnimation", "I", AccessFlags = 25)]
						public const int WallpaperIntraOpenExitAnimation = 16843416;
						/// <java-name>
						/// wallpaperOpenEnterAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperOpenEnterAnimation", "I", AccessFlags = 25)]
						public const int WallpaperOpenEnterAnimation = 16843411;
						/// <java-name>
						/// wallpaperOpenExitAnimation
						/// </java-name>
						[Dot42.DexImport("wallpaperOpenExitAnimation", "I", AccessFlags = 25)]
						public const int WallpaperOpenExitAnimation = 16843412;
						/// <java-name>
						/// webViewStyle
						/// </java-name>
						[Dot42.DexImport("webViewStyle", "I", AccessFlags = 25)]
						public const int WebViewStyle = 16842885;
						/// <java-name>
						/// weightSum
						/// </java-name>
						[Dot42.DexImport("weightSum", "I", AccessFlags = 25)]
						public const int WeightSum = 16843048;
						/// <java-name>
						/// widgetLayout
						/// </java-name>
						[Dot42.DexImport("widgetLayout", "I", AccessFlags = 25)]
						public const int WidgetLayout = 16843243;
						/// <java-name>
						/// width
						/// </java-name>
						[Dot42.DexImport("width", "I", AccessFlags = 25)]
						public const int Width = 16843097;
						/// <java-name>
						/// windowAnimationStyle
						/// </java-name>
						[Dot42.DexImport("windowAnimationStyle", "I", AccessFlags = 25)]
						public const int WindowAnimationStyle = 16842926;
						/// <java-name>
						/// windowBackground
						/// </java-name>
						[Dot42.DexImport("windowBackground", "I", AccessFlags = 25)]
						public const int WindowBackground = 16842836;
						/// <java-name>
						/// windowContentOverlay
						/// </java-name>
						[Dot42.DexImport("windowContentOverlay", "I", AccessFlags = 25)]
						public const int WindowContentOverlay = 16842841;
						/// <java-name>
						/// windowDisablePreview
						/// </java-name>
						[Dot42.DexImport("windowDisablePreview", "I", AccessFlags = 25)]
						public const int WindowDisablePreview = 16843298;
						/// <java-name>
						/// windowEnterAnimation
						/// </java-name>
						[Dot42.DexImport("windowEnterAnimation", "I", AccessFlags = 25)]
						public const int WindowEnterAnimation = 16842932;
						/// <java-name>
						/// windowExitAnimation
						/// </java-name>
						[Dot42.DexImport("windowExitAnimation", "I", AccessFlags = 25)]
						public const int WindowExitAnimation = 16842933;
						/// <java-name>
						/// windowFrame
						/// </java-name>
						[Dot42.DexImport("windowFrame", "I", AccessFlags = 25)]
						public const int WindowFrame = 16842837;
						/// <java-name>
						/// windowFullscreen
						/// </java-name>
						[Dot42.DexImport("windowFullscreen", "I", AccessFlags = 25)]
						public const int WindowFullscreen = 16843277;
						/// <java-name>
						/// windowHideAnimation
						/// </java-name>
						[Dot42.DexImport("windowHideAnimation", "I", AccessFlags = 25)]
						public const int WindowHideAnimation = 16842935;
						/// <java-name>
						/// windowIsFloating
						/// </java-name>
						[Dot42.DexImport("windowIsFloating", "I", AccessFlags = 25)]
						public const int WindowIsFloating = 16842839;
						/// <java-name>
						/// windowIsTranslucent
						/// </java-name>
						[Dot42.DexImport("windowIsTranslucent", "I", AccessFlags = 25)]
						public const int WindowIsTranslucent = 16842840;
						/// <java-name>
						/// windowNoDisplay
						/// </java-name>
						[Dot42.DexImport("windowNoDisplay", "I", AccessFlags = 25)]
						public const int WindowNoDisplay = 16843294;
						/// <java-name>
						/// windowNoTitle
						/// </java-name>
						[Dot42.DexImport("windowNoTitle", "I", AccessFlags = 25)]
						public const int WindowNoTitle = 16842838;
						/// <java-name>
						/// windowShowAnimation
						/// </java-name>
						[Dot42.DexImport("windowShowAnimation", "I", AccessFlags = 25)]
						public const int WindowShowAnimation = 16842934;
						/// <java-name>
						/// windowShowWallpaper
						/// </java-name>
						[Dot42.DexImport("windowShowWallpaper", "I", AccessFlags = 25)]
						public const int WindowShowWallpaper = 16843410;
						/// <java-name>
						/// windowSoftInputMode
						/// </java-name>
						[Dot42.DexImport("windowSoftInputMode", "I", AccessFlags = 25)]
						public const int WindowSoftInputMode = 16843307;
						/// <java-name>
						/// windowTitleBackgroundStyle
						/// </java-name>
						[Dot42.DexImport("windowTitleBackgroundStyle", "I", AccessFlags = 25)]
						public const int WindowTitleBackgroundStyle = 16842844;
						/// <java-name>
						/// windowTitleSize
						/// </java-name>
						[Dot42.DexImport("windowTitleSize", "I", AccessFlags = 25)]
						public const int WindowTitleSize = 16842842;
						/// <java-name>
						/// windowTitleStyle
						/// </java-name>
						[Dot42.DexImport("windowTitleStyle", "I", AccessFlags = 25)]
						public const int WindowTitleStyle = 16842843;
						/// <java-name>
						/// writePermission
						/// </java-name>
						[Dot42.DexImport("writePermission", "I", AccessFlags = 25)]
						public const int WritePermission = 16842760;
						/// <java-name>
						/// x
						/// </java-name>
						[Dot42.DexImport("x", "I", AccessFlags = 25)]
						public const int X = 16842924;
						/// <java-name>
						/// y
						/// </java-name>
						[Dot42.DexImport("y", "I", AccessFlags = 25)]
						public const int Y = 16842925;
						/// <java-name>
						/// yesNoPreferenceStyle
						/// </java-name>
						[Dot42.DexImport("yesNoPreferenceStyle", "I", AccessFlags = 25)]
						public const int YesNoPreferenceStyle = 16842896;
						/// <java-name>
						/// zAdjustment
						/// </java-name>
						[Dot42.DexImport("zAdjustment", "I", AccessFlags = 25)]
						public const int ZAdjustment = 16843201;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Attr() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$array
				/// </java-name>
				[Dot42.DexImport("android/R$array", AccessFlags = 25)]
				public sealed partial class Array
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// emailAddressTypes
						/// </java-name>
						[Dot42.DexImport("emailAddressTypes", "I", AccessFlags = 25)]
						public const int EmailAddressTypes = 17235968;
						/// <java-name>
						/// imProtocols
						/// </java-name>
						[Dot42.DexImport("imProtocols", "I", AccessFlags = 25)]
						public const int ImProtocols = 17235969;
						/// <java-name>
						/// organizationTypes
						/// </java-name>
						[Dot42.DexImport("organizationTypes", "I", AccessFlags = 25)]
						public const int OrganizationTypes = 17235970;
						/// <java-name>
						/// phoneTypes
						/// </java-name>
						[Dot42.DexImport("phoneTypes", "I", AccessFlags = 25)]
						public const int PhoneTypes = 17235971;
						/// <java-name>
						/// postalAddressTypes
						/// </java-name>
						[Dot42.DexImport("postalAddressTypes", "I", AccessFlags = 25)]
						public const int PostalAddressTypes = 17235972;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Array() /* MethodBuilder.Create */ 
						{
						}

				}

				/// <java-name>
				/// android/R$anim
				/// </java-name>
				[Dot42.DexImport("android/R$anim", AccessFlags = 25)]
				public sealed partial class Anim
 /* scope: __dot42__ */ 
				{
						/// <java-name>
						/// accelerate_decelerate_interpolator
						/// </java-name>
						[Dot42.DexImport("accelerate_decelerate_interpolator", "I", AccessFlags = 25)]
						public const int Accelerate_decelerate_interpolator = 17432580;
						/// <java-name>
						/// accelerate_interpolator
						/// </java-name>
						[Dot42.DexImport("accelerate_interpolator", "I", AccessFlags = 25)]
						public const int Accelerate_interpolator = 17432581;
						/// <java-name>
						/// anticipate_interpolator
						/// </java-name>
						[Dot42.DexImport("anticipate_interpolator", "I", AccessFlags = 25)]
						public const int Anticipate_interpolator = 17432583;
						/// <java-name>
						/// anticipate_overshoot_interpolator
						/// </java-name>
						[Dot42.DexImport("anticipate_overshoot_interpolator", "I", AccessFlags = 25)]
						public const int Anticipate_overshoot_interpolator = 17432585;
						/// <java-name>
						/// bounce_interpolator
						/// </java-name>
						[Dot42.DexImport("bounce_interpolator", "I", AccessFlags = 25)]
						public const int Bounce_interpolator = 17432586;
						/// <java-name>
						/// decelerate_interpolator
						/// </java-name>
						[Dot42.DexImport("decelerate_interpolator", "I", AccessFlags = 25)]
						public const int Decelerate_interpolator = 17432582;
						/// <java-name>
						/// fade_in
						/// </java-name>
						[Dot42.DexImport("fade_in", "I", AccessFlags = 25)]
						public const int Fade_in = 17432576;
						/// <java-name>
						/// fade_out
						/// </java-name>
						[Dot42.DexImport("fade_out", "I", AccessFlags = 25)]
						public const int Fade_out = 17432577;
						/// <java-name>
						/// linear_interpolator
						/// </java-name>
						[Dot42.DexImport("linear_interpolator", "I", AccessFlags = 25)]
						public const int Linear_interpolator = 17432587;
						/// <java-name>
						/// overshoot_interpolator
						/// </java-name>
						[Dot42.DexImport("overshoot_interpolator", "I", AccessFlags = 25)]
						public const int Overshoot_interpolator = 17432584;
						/// <java-name>
						/// slide_in_left
						/// </java-name>
						[Dot42.DexImport("slide_in_left", "I", AccessFlags = 25)]
						public const int Slide_in_left = 17432578;
						/// <java-name>
						/// slide_out_right
						/// </java-name>
						[Dot42.DexImport("slide_out_right", "I", AccessFlags = 25)]
						public const int Slide_out_right = 17432579;
						[Dot42.DexImport("<init>", "()V", AccessFlags = 1)]
						public Anim() /* MethodBuilder.Create */ 
						{
						}

				}

		}

}

