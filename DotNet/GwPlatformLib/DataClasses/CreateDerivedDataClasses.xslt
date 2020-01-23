<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>
    <xsl:include href="../CommonXsltTemplates.xslt"/> 

    <xsl:param name="output-filename" select="'output.txt'" />

    <xsl:template match="@* | node()">
        <xsl:copy>
            <xsl:apply-templates select="@* | node()"/>
        </xsl:copy>
    </xsl:template>

    <xsl:template match="/*">
        <FileSet>
            <FileSetFiles>
                <FileSetFile>
                    <RelativePath>
                        <xsl:text>GNodeRole.derived.cs</xsl:text>
                    </RelativePath>
                    <xsl:element name="FileContents" xml:space="preserve">using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;
using GwPlatformDotNet.Lib.Enums;

namespace GwPlatform.Lib.DataClasses
{                            
    public partial class GNodeRole
    {
        public static List&lt;GNodeRole> AllGNodeRoles { get; private set; }

        public static List&lt;String> AllGNodeRoleValues { get; private set; }
    <xsl:for-each select="//GNodeRoles/GNodeRole">
        public static GNodeRole <xsl:value-of select="translate(Value, $lcletters, $ucletters)" /> { get; private set; }
    </xsl:for-each>


        private static  void PopulateGNodeRoles() {
            GNodeRole.AllGNodeRoles  = new List&lt;GNodeRole>();
            GNodeRole.AllGNodeRoleValues = new List&lt;String>();
        <xsl:for-each select="//GNodeRoles/GNodeRole"><xsl:variable name="squot">'</xsl:variable><xsl:variable name="has-agent" select="normalize-space(//FuzzyLogics/FuzzyLogic[FuzzyLogicId = current()/HasAgent]/Key)"/>
            GNodeRole.<xsl:value-of select="translate(Value, $lcletters, $ucletters)"/>  = new GNodeRole() {
                Value = "<xsl:value-of select="Value"/>",
                Definition = @"<xsl:value-of select="translate(Definition, '&#34;', $squot)"/>",
                ColorHex = "<xsl:value-of select="ColorHex"/>",
                HasAgentValue = FuzzyLogic.<xsl:value-of select="translate(HasAgentValue, $lcletters, $ucletters)"/>.Value,
                ElectricallyConnectsAndDisconnectsValue = FuzzyLogic.<xsl:value-of select="translate(ElectricallyConnectsAndDisconnectsValue, $lcletters, $ucletters)"/>.Value,
                HasVoltageValue = FuzzyLogic.<xsl:value-of select="translate(HasVoltageValue, $lcletters, $ucletters)"/>.Value,
                HasPowerLevel = <xsl:choose>
                                    <xsl:when test="HasPowerLevel"><xsl:value-of select="HasPowerLevel"/>
                                    </xsl:when>
                                    <xsl:otherwise>false</xsl:otherwise>
                                </xsl:choose>
            };
            GNodeRole.AllGNodeRoles.Add(GNodeRole.<xsl:value-of select="translate(Value, $lcletters, $ucletters)"/>);
            GNodeRole.AllGNodeRoleValues.Add(GNodeRole.<xsl:value-of select="translate(Value, $lcletters, $ucletters)"/>.Value);
        </xsl:for-each>
        }
    }
}
</xsl:element>
                </FileSetFile>
            </FileSetFiles>
        </FileSet>
    </xsl:template>
</xsl:stylesheet>
