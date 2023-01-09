namespace Interface;
        // class declarations
         class SSH_Interface;
     class SSH_Interface 
    {
        // class delegates
        delegate FUNCTION delegateFromDevice ( SIMPLSHARPSTRING ReturnFromSSH );
        delegate FUNCTION delegateConnectionStatus ( SIMPLSHARPSTRING ConnectedValue );
        delegate FUNCTION delegateFingerprint ( SIMPLSHARPSTRING Fingerprint );

        // class events

        // class functions
        FUNCTION Command_In ( STRING CommandIn );
        FUNCTION Accept_Any_Key ( SIGNED_LONG_INTEGER acceptAnyKey );
        FUNCTION Accept_New_Key ();
        FUNCTION Decline_New_Key ();
        FUNCTION Unique_ID ( INTEGER ID );
        static FUNCTION SaveSettings ();
        FUNCTION LoadSettings ();
        FUNCTION Connect ( STRING Hostname , SIGNED_LONG_INTEGER Port , STRING Username , STRING Password );
        FUNCTION Disconnect ();
        FUNCTION Debug ( SIGNED_LONG_INTEGER Debug__1__ );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty delegateFromDevice SendFromDevice;
        DelegateProperty delegateConnectionStatus SendConnectionStatus;
        DelegateProperty delegateFingerprint SendFingerprint;
    };

