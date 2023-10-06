using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    IdMeal = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StrMeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrInstructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMealThumb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrYoutube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrIngredient30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure21 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure22 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure23 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure24 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure25 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure26 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure27 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure28 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure29 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StrMeasure30 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.IdMeal);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdentityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInfo_FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInfo_LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInfo_EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInfo_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasicInfo_DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BasicInfo_CurrentCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserProfileId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserCaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserCaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserCaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FriendRequests",
                columns: table => new
                {
                    FriendRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequesterUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReceiverUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateResponded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Response = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendRequests", x => x.FriendRequestId);
                    table.ForeignKey(
                        name: "FK_FriendRequests_UserProfiles_ReceiverUserProfileId",
                        column: x => x.ReceiverUserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                    table.ForeignKey(
                        name: "FK_FriendRequests_UserProfiles_RequesterUserProfileId",
                        column: x => x.RequesterUserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "Friendships",
                columns: table => new
                {
                    FriendshipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstFriendUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SecondFriendUserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DateEstablished = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FriendshipStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friendships", x => x.FriendshipId);
                    table.ForeignKey(
                        name: "FK_Friendships_UserProfiles_FirstFriendUserProfileId",
                        column: x => x.FirstFriendUserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                    table.ForeignKey(
                        name: "FK_Friendships_UserProfiles_SecondFriendUserProfileId",
                        column: x => x.SecondFriendUserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostComment",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostComment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_PostComment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostInteraction",
                columns: table => new
                {
                    InteractionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InteractionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostInteraction", x => x.InteractionId);
                    table.ForeignKey(
                        name: "FK_PostInteraction_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostInteraction_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserCaims_UserId",
                table: "AspNetUserCaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequests_ReceiverUserProfileId",
                table: "FriendRequests",
                column: "ReceiverUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendRequests_RequesterUserProfileId",
                table: "FriendRequests",
                column: "RequesterUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_FirstFriendUserProfileId",
                table: "Friendships",
                column: "FirstFriendUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Friendships_SecondFriendUserProfileId",
                table: "Friendships",
                column: "SecondFriendUserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId",
                table: "PostComment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInteraction_PostId",
                table: "PostInteraction",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostInteraction_UserProfileId",
                table: "PostInteraction",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserProfileId",
                table: "Posts",
                column: "UserProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserCaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FriendRequests");

            migrationBuilder.DropTable(
                name: "Friendships");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "PostComment");

            migrationBuilder.DropTable(
                name: "PostInteraction");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "UserProfiles");
        }
    }
}
