# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class Resource(Model):

    _required = []

    _attribute_map = {
        'id': {'key': 'id', 'type': 'str'},
        'type': {'key': 'type', 'type': 'str'},
        'tags': {'key': 'tags', 'type': '{str}'},
        'location': {'key': 'location', 'type': 'str'},
        'name': {'key': 'name', 'type': 'str'},
    }

    def __init__(self, *args, **kwargs):
        """Resource

        :param str id: Resource Id
        :param str type: Resource Type
        :param dict tags
        :param str location: Resource Location
        :param str name: Resource Name
        """
        self.id = None
        self.type = None
        self.tags = None
        self.location = None
        self.name = None

        super(Resource, self).__init__(*args, **kwargs)
