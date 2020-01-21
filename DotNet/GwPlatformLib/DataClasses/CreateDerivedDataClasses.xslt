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
        private static  void PopulateAllGNRs() {
            GNodeRole.AllGNRs = new List&lt;GNodeRole>();
            GNodeRole.GNRsByEnum = new Dictionary&lt;GNodeRoleEnum, GNodeRole>();
            GNodeRole.GNRsByName = new Dictionary&lt;String, GNodeRole>();

        <xsl:for-each select="//GNodeRoles/GNodeRole"><xsl:variable name="squot">'</xsl:variable><xsl:variable name="has-agent" select="normalize-space(//FuzzyLogics/FuzzyLogic[FuzzyLogicId = current()/HasAgent]/Key)"/>
            var gnr<xsl:value-of select="Name"/> = new GNodeRole() {
                Name = "<xsl:value-of select="Name"/>",
                Definition = @"<xsl:value-of select="translate(Definition, '&#34;', $squot)"/>",
                ColorHex = "<xsl:value-of select="ColorHex"/>",
                HasAgentEnum = FuzzyLogicEnum.<xsl:choose>
                    <xsl:when test="$has-agent = 'TRUE'">TRUE</xsl:when>
                    <xsl:when test="$has-agent = 'checked'">TRUE</xsl:when>
                    <xsl:when test="$has-agent = 'FALSE'">FALSE</xsl:when>
                    <xsl:when test="$has-agent = ''">FALSE</xsl:when>
                    <xsl:otherwise>MAYBE</xsl:otherwise>
                </xsl:choose>,
                ElectricallyConnectsAndDisconnectsEnum = FuzzyLogicEnum.TRUE,
                HasPowerLevel = true,
                HasVoltageEnum = FuzzyLogicEnum.TRUE
            };
            GNodeRole.AllGNRs.Add(gnr<xsl:value-of select="Name"/>);
            GNodeRole.GNRsByEnum[GNodeRoleEnum.<xsl:value-of select="translate(Name, $lcletters, $ucletters)"/>] = gnr<xsl:value-of select="Name"/>;
            GNodeRole.GNRsByName["<xsl:value-of select="translate(Name, $lcletters, $ucletters)"/>"] = gnr<xsl:value-of select="Name"/>;
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
