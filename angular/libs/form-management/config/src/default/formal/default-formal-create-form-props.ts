import { ePropType, FormProp } from '@abp/ng.theme.shared/extensions';
import {Fs} from '@fs-tw/form-management/proxy';

export const DEFAULT_FORMAL_CREATE_FORM_PROPS = FormProp.createMany<Fs.FormManagement.Forms.Dtos.FormalDto>([
  
   {
    type: ePropType.String,
    name: 'no',
    displayName: 'FormManagement::FS.Formal.No',
    id: 'no',
    defaultValue: ""
  },
  {
    type: ePropType.String,
    name: 'displayName',
    displayName: 'FormManagement::FS.Formal.DisplayName',
    id: 'displayName',
    defaultValue: ""
  },
  {
    type: ePropType.String,
    name: 'versionid',
    displayName:'FormManagement::FS.Formal.VersionId',
    id: 'versionid',
    defaultValue: "",
  }
]);