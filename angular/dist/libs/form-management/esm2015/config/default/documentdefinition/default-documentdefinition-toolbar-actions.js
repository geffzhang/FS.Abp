import { ToolbarAction } from '@abp/ng.theme.shared/extensions';
import { ExtensionsService } from '../../services/extensions.service';
const ɵ0 = data => {
    const service = data.getInjected(ExtensionsService);
    service.action("FormManagement::FS.DocumentDefinition" /* DocumentDefinition */, {
        name: 'Add'
    });
    //const component = data.getInjected(UsersComponent);
    //component.add();
};
export const DEFAULT_DOCUMENTDEFINITION_TOOLBAR_ACTIONS = ToolbarAction.createMany([
    {
        text: '新增',
        action: ɵ0,
        //permission: 'AbpIdentity.Users.Create',
        icon: 'fa fa-plus',
    },
]);
export { ɵ0 };
//# sourceMappingURL=default-documentdefinition-toolbar-actions.js.map